import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable, map, combineLatest, switchMap, startWith, Subject, tap, of, merge, filter, distinctUntilChanged, withLatestFrom, catchError } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { CommonTagsByMoodsForm, GetCommonTagsByMoodsResponse, GetMoodResponse, GetMoodsResponse, MoodFull, MoodLight } from '../../interfaces/mood';
import { BaseResponse } from '../../interfaces/base-response';
import { GetOneVideoDetailsResponse, Video } from '../../interfaces/mood-video';
import { GetOneImageDetailsResponse, Image } from '../../interfaces/mood-image';
import { GetOneVideoYoutubeDetailsResponse, VideoYouTube } from '../../interfaces/mood-video-youtube';
import { MoodScoreUpdate, MoodUpdateForm, MultiTagsForm } from '../../interfaces/forms-update';
import { NotificationService } from '../notification.service';
import { StateService } from '../custom-state/state.service';
import { StorageService } from '../storage.service';
import { StorageProperties } from '../../enumerations/storage-properties';
import { ArtistCheckBox, ArtistLight, GetArtistsByMoodResponse, GetArtistsCheckBoxesByMoodResponse } from '../../interfaces/artist';
import { FranchiseLight, GetFranchisesByMoodResponse } from '../../interfaces/franchise';
import { GetModelsByMoodResponse, GetModelsCheckBoxesByMoodResponse, ModelCheckBox, ModelLight } from '../../interfaces/model';
import { GetTagsByMoodResponse, GetTagsCheckBoxesByMoodResponse, TagLight, TagsCheckBoxesList } from '../../interfaces/tag';
import { StatisticsService } from './statistics.service';
import { CreateMoodImageResponse, CreateMoodVideoResponse } from '../../interfaces/responses-create';
import { ImageCreateForm, VideoCreateForm } from '../../interfaces/forms-create';
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode';
import { MoodsGalleryService } from '../moods-gallery.service';

type MoodFilter =
  | { type: GalleryMode.Tag, id: number }
  | { type: GalleryMode.TagCategory, id: number }
  | { type: GalleryMode.Artist, id: number }
  | { type: GalleryMode.Model, id: number }
  | { type: GalleryMode.Franchise, id: number }
  | { type: GalleryMode.Default }


@Injectable({
  providedIn: 'root'
})

export class MoodService {
  #stateService = inject(StateService)
  #moodsGalleryService = inject(MoodsGalleryService)

  #http = inject(HttpClient)
  #storageService = inject(StorageService)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  #refreshMoods$ = new Subject<void>()

  #activeFilter$ = combineLatest([
    this.#moodsGalleryService.galleryMode$,
    this.#stateService.modelId$,
    this.#stateService.artistId$,
    this.#stateService.tagId$,
    this.#stateService.tagCategoryId$,
    this.#stateService.franchiseId$,
    this.#moodsGalleryService.activeEntity$
  ]).pipe(
    map(([galleryMode, modelId, artistId, tagId, tagCategoryId, franchiseId, activeEntity]): MoodFilter => {
      if (activeEntity === ActiveEntity.Franchise && galleryMode === GalleryMode.Model && franchiseId != null) {
        return { type: GalleryMode.Franchise, id: franchiseId }
      }
      else if (activeEntity === ActiveEntity.Model && galleryMode === GalleryMode.Franchise && modelId != null) {
        return { type: GalleryMode.Model, id: modelId }
      }
      switch (galleryMode) {
        case GalleryMode.Model:
          return modelId != null ? { type: GalleryMode.Model, id: modelId } : { type: GalleryMode.Default }
        case GalleryMode.Artist:
          return artistId != null ? { type: GalleryMode.Artist, id: artistId } : { type: GalleryMode.Default }
        case GalleryMode.Tag:
          return tagId != null ? { type: GalleryMode.Tag, id: tagId } : { type: GalleryMode.Default }
        case GalleryMode.TagCategory:
          return tagCategoryId != null ? { type: GalleryMode.TagCategory, id: tagCategoryId } : { type: GalleryMode.Default }
        case GalleryMode.Franchise:
          return franchiseId != null ? { type: GalleryMode.Franchise, id: franchiseId } : { type: GalleryMode.Default }
        default:
          return { type: GalleryMode.Default }
      }
    }),
    distinctUntilChanged((prev, curr) => JSON.stringify(prev) === JSON.stringify(curr))
  )

  #moods$ = merge(
    this.#activeFilter$.pipe(
      switchMap(filter => this.getMoodsByFilter(filter))
    ),
    this.#refreshMoods$.pipe(
      withLatestFrom(this.#activeFilter$),
      switchMap(([_, filter]) => this.getMoodsByFilter(filter))
    )
  )

  #mood$ = this.#stateService.moodId$.pipe(
    startWith(undefined),
    switchMap(moodId => {
      if (moodId == undefined) return this.getRandomMood()
      else return this.getMoodById(moodId)
    }),
    switchMap(mood => {
      if (!mood || !mood.businessId) return of(undefined)

      let media$: Observable<any>
      switch (mood.type) {
        case 1:
          media$ = this.getImage(mood.businessId).pipe(
            map(image => ({
              mediaType: 'Image',
              width: image?.width,
              height: image?.height,
              size: image?.size
            }))
          )
          break
        case 2:
          media$ = this.getVideo(mood.businessId).pipe(
            map(video => ({
              mediaType: 'Video',
              width: video?.width,
              height: video?.height,
              duration: video?.duration,
              size: video?.size
            }))
          )
          break
        case 4:
          media$ = this.getVideoYoutube(mood.businessId).pipe(
            map(videoYouTube => ({
              mediaType: 'VideoYouTube',
              url: videoYouTube?.url
            }))
          )
          break
        default:
          media$ = of({})
      }

      const tags$ = this.getTagsByMood(mood.businessId)
      const models$ = this.getModelsByMood(mood.businessId)
      const artists$ = this.getArtistsByMood(mood.businessId)
      const franchises$ = this.getFranchisesByMood(mood.businessId)

      return combineLatest([media$, tags$, models$, artists$, franchises$]).pipe(
        map(([mediaProps, tags, models, artists, franchises]) => ({
          ...mood,
          ...mediaProps,
          relatedTags: tags,
          relatedModels: models,
          relatedArtists: artists,
          relatedFranchises: franchises
        }))
      )
    }),
    startWith(undefined)
  )

  constructor() {
    let storedMoodId = this.#storageService.getItem(StorageProperties.StateMoodId)
    if (storedMoodId != null) { this.#stateService.setMoodId(storedMoodId as number) }
  }

  private getMoodsByFilter(filter: MoodFilter): Observable<MoodLight[]> {
    switch (filter.type) {
      case GalleryMode.Tag:
        return this.getMoodsByTag(filter.id)
      case GalleryMode.TagCategory:
        return this.getMoodsByTagCategory(filter.id)
      case GalleryMode.Artist:
        return this.getMoodsByArtist(filter.id)
      case GalleryMode.Model:
        return this.getMoodsByModel(filter.id)
      case GalleryMode.Franchise:
        return this.getMoodsByFranchise(filter.id)
      case GalleryMode.Default:
      default:
        return this.getAllMoods()
    }
  }

  public getAllMoods(): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetAll`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }

  public getRandomMood(): Observable<MoodFull | undefined> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetailsRandom`).pipe(
      tap(response => {
        if (response.success) {
          this.#stateService.setMoodId(response.mood.businessId)
        }
        else this.#notificationService.error(response.message)
      }),
      map(response => response.mood),
      catchError(() => of(undefined)))
  }

  public getMoodById(moodId: number): Observable<MoodFull | undefined> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetails/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.mood),
      catchError(() => of(undefined)))
  }

  public getArtistsByMood(moodId: number): Observable<ArtistLight[]> {
    return this.#http.get<GetArtistsByMoodResponse>(`${this.#url}Artists/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artistsByMood),
      catchError(() => of([])))
  }

  public getTagsByMood(moodId: number): Observable<TagLight[]> {
    return this.#http.get<GetTagsByMoodResponse>(`${this.#url}Tags/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagsByMood),
      catchError(() => of([])))
  }

  public getModelsByMood(moodId: number): Observable<ModelLight[]> {
    return this.#http.get<GetModelsByMoodResponse>(`${this.#url}Models/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models),
      catchError(() => of([])))
  }

  public getFranchisesByMood(moodId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByMoodResponse>(`${this.#url}Franchises/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchisesByMood),
      catchError(() => of([])))
  }

  public getMoodsByTag(tagId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTag/${tagId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }

  public getMoodsByTagCategory(tagCategoryId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTagCategory/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }
  
  public getMoodsByModel(modelId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByModel/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }

  public getMoodsByArtist(artistId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByArtist/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }

  public getMoodsByFranchise(franchiseId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods),
      catchError(() => of([])))
  }

  public getImage(businessId: number): Observable<Image | undefined> {
    return this.#http.get<GetOneImageDetailsResponse>(`${this.#url}Images/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.image),
      catchError(() => of(undefined)))
  }

  public getVideo(businessId: number): Observable<Video | undefined> {
    return this.#http.get<GetOneVideoDetailsResponse>(`${this.#url}Videos/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.video),
      catchError(() => of(undefined)))
  }

  public getVideoYoutube(businessId: number): Observable<VideoYouTube | undefined> {
    return this.#http.get<GetOneVideoYoutubeDetailsResponse>(`${this.#url}VideosYouTube/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.videoYouTube),
      catchError(() => of(undefined)))
  }

  public getTagsCheckBoxesByMood(moodId: number): Observable<TagsCheckBoxesList[]> {
    return this.#http.get<GetTagsCheckBoxesByMoodResponse>(`${this.#url}Tags/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagsCheckBoxesList),
      catchError(() => of([])))
  }

  public getArtistsCheckBoxesByMood(moodId: number): Observable<ArtistCheckBox[]> {
    return this.#http.get<GetArtistsCheckBoxesByMoodResponse>(`${this.#url}Artists/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artists),
      catchError(() => of([])))
  }

  public getModelsCheckBoxesByMood(moodId: number): Observable<ModelCheckBox[]> {
    return this.#http.get<GetModelsCheckBoxesByMoodResponse>(`${this.#url}Models/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models),
      catchError(() => of([])))
  }

  public getCommonTagsByMoods(form: CommonTagsByMoodsForm): Observable<TagsCheckBoxesList[]> {
    return this.#http.post<GetCommonTagsByMoodsResponse>(`${this.#url}Moods/GetCommonTagsByMoods`, form).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.commonTags),
      catchError(() => of([])))
  }
  
  public createImage(form: ImageCreateForm): Observable<CreateMoodImageResponse> {
    return this.#http.post<CreateMoodImageResponse>(`${this.#url}Moods/CreateMoodImage`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshMoods$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', moodId: undefined } as CreateMoodImageResponse)))
  }

  public createVideo(form: VideoCreateForm): Observable<CreateMoodVideoResponse> {
    return this.#http.post<CreateMoodVideoResponse>(`${this.#url}Moods/CreateMoodVideo`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#refreshMoods$.next()
          this.#stateService.setMoodId(response.moodId)
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error', moodId: undefined } as CreateMoodVideoResponse)))
  }

  public updateMood(form: MoodUpdateForm): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Moods/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(form.moodId)
          this.#refreshMoods$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public updateMoodScore(form: MoodScoreUpdate): Observable<BaseResponse> {
    return this.#http.put<BaseResponse>(`${this.#url}Moods/UpdateScore`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(form.moodId)
          this.#refreshMoods$.next()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public multiTags(form: MultiTagsForm): Observable<BaseResponse> {
    return this.#http.post<BaseResponse>(this.#url + 'Moods/MultiTags', form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#refreshMoods$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }  

  public deleteMood(moodId: number): Observable<BaseResponse> {
    return this.#http.delete<BaseResponse>(`${this.#url}Moods/Delete/${moodId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(undefined)
          this.#refreshMoods$.next()
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }),
      catchError(() => of({ success: false, message: 'Error' } as BaseResponse)))
  }

  public moodsFlow = toSignal(
    combineLatest({
      moods: this.#moods$,
      mood: this.#mood$
    })
  )
}