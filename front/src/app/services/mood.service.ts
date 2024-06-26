import { HttpClient } from "@angular/common/http";
import { Injectable, inject } from "@angular/core";
import { BehaviorSubject, switchMap, map, combineLatest, of, tap, catchError, take, Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { GetModelsCheckBoxesByMoodResponse, GetModelsResponse } from "../models/model";
import { GetMoodByIdResponse, GetMoodsResponse, MoodUpdateForm, MoodUpdateResponse, UpdateMoodScoreCall, UpdateMoodScoreResponse } from "../models/mood";
import { toSignal } from "@angular/core/rxjs-interop";
import { GetFranchisesByMoodResponse } from "../models/franchise";
import { GetOneTagDetailsResponse, GetTagsByMoodResponse, GetTagsCheckBoxesByMoodResponse } from "../models/tag";
import { CreateMoodImageResponse, GetOneImageDetailsResponse, ImageForm } from "../models/mood-image";
import { GetOneVideoDetailsResponse, Video } from "../models/mood-video";
import { Image } from "../models/mood-image";
import { GetOneVideoYoutubeDetailsResponse, VideoYouTube } from "../models/mood-video-youtube";
import { GetArtistsByMoodResponse, GetArtistsCheckBoxesByMoodResponse } from "../models/artist";
import { BaseResponse } from "../models/base-response";

type Media = Image | Video | VideoYouTube | null

@Injectable({
  providedIn: 'root'
})
export class MoodStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedGalleryType = new BehaviorSubject<string | null>(null)
  selectedGalleryType$ = this.#selectedGalleryType.asObservable()
  updateSelectedGalleryType( galleryType : string | null) : void { this.#selectedGalleryType.next( galleryType ) }

  #selectedMoodId = new BehaviorSubject<number | null>(null)
  selectedMoodId$ = this.#selectedMoodId.asObservable()
  updateSelectedMoodId(moodId : number | null) : void { this.#selectedMoodId.next(moodId) }

  #selectedTagId = new BehaviorSubject<number | null>(null)
  selectedTagId$ = this.#selectedTagId.asObservable()
  updateSelectedTagId(TagId : number | null) { this.#selectedTagId.next(TagId) }

  #selectedModelId = new BehaviorSubject<number | null>(null)
  selectedModelId$ = this.#selectedModelId.asObservable()
  updateSelectedModelId( modelId : number | null ) : void { this.#selectedModelId.next(modelId) }

  #selectedArtistId = new BehaviorSubject<number | null>(null)
  selectedArtistId$ = this.#selectedArtistId.asObservable()
  updateSelectedArtistId( artistId : number | null ) : void { this.#selectedArtistId.next(artistId) }

  #selectedFranchiseId = new BehaviorSubject<number | null>(null)
  selectedFranchiseId$ = this.#selectedFranchiseId.asObservable()
  updateSelectedFranchiseId( franchiseId : number | null ) : void { this.#selectedFranchiseId.next(franchiseId) }

  moodsFlow$ = this.selectedGalleryType$.pipe(
    switchMap(galleryType => {
      switch (galleryType) {
        case 'tag':
          return this.selectedTagId$.pipe(
            switchMap(tagId => {
              if (tagId === null) return of({ moodsList: [], tagDetails: null })
              else 
              {
                return combineLatest([
                  this.getMoodsByTag(tagId),
                  this.getOneTagDetails(tagId)
                ]).pipe(
                  map(([moods, tagDetails]) => ({
                    moodsList : moods.sort((a, b) => b.score - a.score),
                    tagDetails : tagDetails
                  }))
                )
              }
            })
          )  
        case 'artist':
          return this.selectedArtistId$.pipe(
            switchMap(artistId => {
              if (artistId === null) return of({ moodsList: [], tagDetails: null })
              else 
              {
                return this.getMoodsByArtist(artistId).pipe(
                  map(moods => ({
                    moodsList : moods.sort((a, b) => b.score - a.score),
                    tagDetails : null
                  }))
                )
              }
            })
          )  
        case 'model':
          return this.selectedModelId$.pipe(
            switchMap(modelId => {
              if (modelId === null) return of({ moodsList: [], tagDetails: null })
              else 
              {
                return this.getMoodsByModel(modelId).pipe(
                  map(moods => ({
                    moodsList: moods.sort((a, b) => b.score - a.score),
                    tagDetails: null
                  }))
                )
              }
            })
          )  
        default:
          return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetAll`).pipe(
            map(response => ({
              moodsList: response.moods.sort((a, b) => b.score - a.score),
              tagDetails: null
            }))
          )
      }
    })
  )
  moodsFlow = toSignal(this.moodsFlow$, { initialValue: { moodsList: [], tagDetails: null } })

  moodFlow$ = this.#selectedMoodId.pipe(
    switchMap(moodId => this.getMood(moodId)),
    switchMap(mood => {
      if (!mood || mood.businessId == null) return of({ mood: null, models: [], franchises: [], artists : [], tags: [], media: null })
      let mediaObservable$
      switch (mood.type) 
      {
        case 1:   // Image
          mediaObservable$ = this.getImage(mood.businessId).pipe(map(response => response as Media))
          break;
        case 2:   // Video
          mediaObservable$ = this.getVideo(mood.businessId).pipe(map(response => response as Media))
          break;
        case 4:   // VideoYouTube
          mediaObservable$ = this.getVideoYoutube(mood.businessId).pipe(map(response => response as Media))
          break;
        default:  // No Type
          mediaObservable$ = of(null)
      }
  
      return combineLatest([
        of(mood),
        this.getModelsByMood(mood.businessId),
        this.getFranchisesByMood(mood.businessId),
        this.getArtistsByMood(mood.businessId),
        this.getTagsByMood(mood.businessId),
        mediaObservable$
      ]).pipe(
        map(([mood, models, franchises, artists, tags, media]) => ({
          mood, models, franchises, artists, tags, media
        }))
        )
      }),
    )      
  getMoodFlow = toSignal(this.moodFlow$, { initialValue: { mood: null, models: [], franchises : [], artists : [],tags : [], media : null } })

  newMoodsFlow$ = combineLatest([
    this.moodFlow$,
    this.moodsFlow$
  ]).pipe(
    map(([moodFlow, moodsFlow]) => 
      {
      let moodsList = moodsFlow.moodsList
      let selectedMoodId = moodFlow.mood?.businessId
      let currentIndex = moodsList.findIndex(mood => mood.businessId === selectedMoodId)
  
      let previousMoodId: number | null = currentIndex > 0 ? moodsList[currentIndex - 1].businessId : moodsList.length ? moodsList[moodsList.length - 1]?.businessId : null
      let nextMoodId: number | null = currentIndex < moodsList.length - 1 ? moodsList[currentIndex + 1].businessId : moodsList.length ? moodsList[0]?.businessId : null
  
      return { ...moodsFlow, currentIndex, previousMoodId, nextMoodId }
    })
  )
  newMoodsFlow = toSignal(this.newMoodsFlow$, { initialValue: 
    {
      moodsList: [],
      tagDetails: null,
      currentIndex: -1,
      previousMoodId: null,
      nextMoodId: null,
    } 
  })  

  getMood(moodId: number | null) 
  {
    const url = moodId === null ? `${this.#url}Moods/GetOneDetailsRandom` : `${this.#url}Moods/GetOneDetails/${moodId}`
    return this.#http.get<GetMoodByIdResponse>(url).pipe(
      tap(response => 
      {
        if (moodId === null && response.mood && response.mood.businessId) this.updateSelectedMoodId(response.mood.businessId)
      }),
      map(response => response.mood)
    )
  }

  getMoodsByTag(TagId : number | null)
  {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTag/${TagId}`).pipe( 
      map(response => response.moods) )
  }

  getMoodsByModel( modelId : number )
  {
    return this.#http.get<GetMoodsResponse>(this.#url + 'Moods/GetByModel/' + modelId).pipe(
      map(response => response.moods)
    )
  }

  getMoodsByArtist( artistId : number )
  {
    return this.#http.get<GetMoodsResponse>(this.#url + 'Moods/GetByArtist/' + artistId).pipe(
      map(response => response.moods)
    )
  }

  getOneTagDetails(TagId : number) 
  {
    return this.#http.get<GetOneTagDetailsResponse>(`${this.#url}Tags/GetOneDetails/${TagId}`).pipe(
      map(response => response.tag)
    )
  }

  getImage(businessId : number) 
  {
    return this.#http.get<GetOneImageDetailsResponse>(`${this.#url}Images/GetOneDetails/${businessId}`).pipe( 
      map(response => response.image) )
  }

  getVideo(businessId : number) 
  {
    return this.#http.get<GetOneVideoDetailsResponse>(`${this.#url}Videos/GetOneDetails/${businessId}`).pipe( 
      map(response => response.video) )
  }

  getVideoYoutube(businessId : number) 
  {
    return this.#http.get<GetOneVideoYoutubeDetailsResponse>(`${this.#url}VideosYouTube/GetOneDetails/${businessId}`).pipe( 
      map(response => response.videoYouTube) )
  }

  getModelsByMood(businessId : number) 
  {
    return this.#http.get<GetModelsResponse>(`${this.#url}Models/GetByMood/${businessId}`).pipe( 
      map(response => response.models) )
  }

  getFranchisesByMood(businessId : number) 
  {
    return this.#http.get<GetFranchisesByMoodResponse>(`${this.#url}Franchises/GetByMood/${businessId}`).pipe( 
      map(response => response.franchisesByMood) )
  }

  getArtistsByMood(businessId : number) 
  {
    return this.#http.get<GetArtistsByMoodResponse>(`${this.#url}Artists/GetByMood/${businessId}`).pipe( 
      map(response => response.artistsByMood) )
  }

  getTagsByMood(businessId : number) 
  {
    return this.#http.get<GetTagsByMoodResponse>(`${this.#url}Tags/GetByMood/${businessId}`).pipe( 
      map(response => response.tagsByMood) )
  }

  updateScoreTrigger(form: UpdateMoodScoreCall) 
  {
    this.#http.put<UpdateMoodScoreResponse>(`${this.#url}Moods/UpdateScore`, form).pipe(
      take(1),
      tap(response => 
        {
        if (response.success) 
          {
          this.updateSelectedMoodId(form.businessId)
        }
      }),
      catchError(error => 
      {
        console.error('Erreur lors de la mise à jour du score:', error)
        return of(null);
      })
    ).subscribe()
  }
  getTagsCheckBoxesByMood( moodId : number | null ) 
  {
    return this.#http.get<GetTagsCheckBoxesByMoodResponse>(`${this.#url}Tags/GetCheckBoxesByMood/${moodId}`).pipe( 
      map(response => response.tagsCheckBoxesList) )
  }

  getModelsCheckBoxesByMood( moodId : number | null ) 
  {
    return this.#http.get<GetModelsCheckBoxesByMoodResponse>(`${this.#url}Models/GetCheckBoxesByMood/${moodId}`).pipe( 
      map(response => response.models) )
  }

  getArtistsCheckBoxesByMood( moodId : number | null ) 
  {
    return this.#http.get<GetArtistsCheckBoxesByMoodResponse>(`${this.#url}Artists/GetCheckBoxesByMood/${moodId}`).pipe( 
      map(response => response.artists) )
  }

  moodEditionFlow$ = this.selectedMoodId$.pipe(
    switchMap(moodId => {
      if (moodId === null) return of({ mood: null, tagsCheckBoxes: [], artists : [], models : [] })
      else 
      {
        return combineLatest([
          this.getMood(moodId),
          this.getTagsCheckBoxesByMood(moodId),
          this.getArtistsCheckBoxesByMood(moodId),
          this.getModelsCheckBoxesByMood(moodId)
        ]).pipe(
          map(([mood, tagsCheckBoxes, artists, models]) => ({
            mood,
            tagsCheckBoxes,
            artists,
            models
          })),
          catchError(error => {
            console.error('Erreur lors de la récupération des données du mood ou des tags:', error)
            return of({ mood : null, tagsCheckBoxes : [], artists : [], models : [] })
          })
        )
      }
    })
  )
  moodEditionFlow = toSignal(this.moodEditionFlow$, { initialValue: { mood: null, tagsCheckBoxes: [], artists : [], models : [] } })

  // Update Mood
  public UpdateMood( form : MoodUpdateForm ) : Observable<number> 
  { 
    return this.#http.put<MoodUpdateResponse>(`${this.#url}Moods/Update`, form).pipe(
      map(response => response.updatedMood.businessId),
      tap(businessId => this.updateSelectedMoodId(businessId))
    )
  }

  // Insert new Image
  public Insert(form : ImageForm) : Observable<number> 
  {
    return this.#http.post<CreateMoodImageResponse>(`${this.#url}Moods/CreateMoodImage`, form).pipe(
      map(response => response.mood.businessId),
      tap(businessId => this.updateSelectedMoodId(businessId))
    )
  }

  // Delete Mood
  public Delete( moodId : number )
  {
    return this.#http.delete<BaseResponse>(`${this.#url}Moods/Delete/${moodId}`).pipe(
      tap( () => {
        this.updateSelectedMoodId(null)
        this.updateSelectedGalleryType('')
      })
    )
  }
}