import { HttpClient } from "@angular/common/http";
import { Injectable, inject } from "@angular/core";
import { BehaviorSubject, switchMap, map, combineLatest, of } from "rxjs";
import { environment } from "../../../environments/environment";
import { GetModelsByMoodResponse } from "../models/model";
import { GetMoodsByTagResponse, MoodFull, MoodsGetAllResponse, MoodsGetOneDetailsResponse } from "../models/mood";
import { toSignal } from "@angular/core/rxjs-interop";
import { GetFranchisesByMoodResponse } from "../models/franchise";
import { GetOneTagDetailsResponse, GetTagsByMoodResponse } from "../models/tag";
import { GetOneImageDetailsResponse } from "../models/mood-image";
import { GetOneVideoDetailsResponse, Video } from "../models/mood-video";
import { Image } from "../models/mood-image";
import { GetOneVideoYoutubeDetailsResponse, VideoYouTube } from "../models/mood-video-youtube";
import { GetArtistsByMoodResponse } from "../models/artist";

type Media = Image | Video | VideoYouTube | null

@Injectable({
  providedIn: 'root'
})
export class MoodStateService 
{
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  #selectedMoodId = new BehaviorSubject<number | null>(null)
  selectedMoodId$ = this.#selectedMoodId.asObservable()

  updateSelectedMoodId(moodId : number | null) : void
  {
    this.#selectedMoodId.next(moodId)
  }

  #selectedTagId = new BehaviorSubject<number | null>(null)
  selectedTagId$ = this.#selectedTagId.asObservable()

  updateSelectedTagId(TagId : number | null)
  {
    this.#selectedTagId.next(TagId)
  }

  moodsFlow$ = this.#selectedTagId.pipe(
    switchMap(TagId => {
      if (TagId === null) 
        {
        return this.#http.get<MoodsGetAllResponse>(`${this.#url}Moods/GetAll`).pipe(
          map(response => ({ moodsList: response.moodsList, tagDetails: null }))
        )
      } 
      else 
      {
        return combineLatest([
          this.getMoodsByTag(TagId).pipe(
            map(response => response)
          ),
          this.getOneTagDetails(TagId).pipe(
            map(response => response)
          )
        ]).pipe(
          map(([moods, tagDetails]) => ({ moodsList: moods, tagDetails }))
        )
      }
    })
  )
  moodsFlow = toSignal(this.moodsFlow$, { initialValue: { moodsList: [], tagDetails: null } })


  moodFlow$ = this.#selectedMoodId.pipe(
    switchMap(moodId => this.getMood(moodId)),
    switchMap(mood => {
      if (!mood || mood.businessId == null) {
        return of({ mood: new MoodFull(), models: [], franchises: [], artists : [], tags: [], media: null })
      }
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
  getMoodFlow = toSignal(this.moodFlow$, { initialValue: { mood: new MoodFull(), models: [], franchises : [], artists : [],tags : [], media : null } })
      
  getMood(moodId : number | null)
  {
    const url = moodId === null ? `${this.#url}Moods/GetOneDetailsRandom` : `${this.#url}Moods/GetOneDetails/${moodId}`
    return this.#http.get<MoodsGetOneDetailsResponse>(url).pipe( map(response => response.mood) )
  }

  getMoodsByTag(TagId : number | null)
  {
    return this.#http.get<GetMoodsByTagResponse>(`${this.#url}Moods/GetByTag/${TagId}`).pipe( 
      map(response => response.moods) )
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
    return this.#http.get<GetModelsByMoodResponse>(`${this.#url}Models/GetByMood/${businessId}`).pipe( 
      map(response => response.modelsByMood) )
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

}