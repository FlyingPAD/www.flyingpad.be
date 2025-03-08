import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable, map, of, combineLatest, BehaviorSubject, switchMap, startWith, Subject, tap } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { CommonTagsByMoodsForm, GetCommonTagsByMoodsResponse, GetMoodResponse, GetMoodsResponse, MoodFull, MoodLight } from '../../interfaces/mood';
import { GetAllTagsResponse, GetTagByIdResponse, GetTagsByCategoryResponse, GetTagsByMoodResponse, TagFull, TagLight } from '../../interfaces/tag';
import { ArtistFull, ArtistLight, GetAllArtistsResponse, GetArtistByIdResponse, GetArtistsByMoodResponse, GetArtistsByStyleResponse, GetArtistsCheckBoxesByMoodResponse } from '../../interfaces/artist';
import { GetAllModelsResponse, GetModelResponse, GetModelsCheckBoxesByMoodResponse, ModelFull, ModelLight } from '../../interfaces/model';
import { GetLinkCategoriesCheckBoxesResponse, GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, GetLinksResponse, LinkCategoryFull, LinkFull, LinkLight } from '../../interfaces/link';
import { FranchiseFull, FranchiseLight, GetAllFranchisesResponse, GetAllMediaResponse, GetFranchiseByIdResponse, GetFranchisesByMediumResponse, GetFranchisesByMoodResponse, GetFranchisesCheckBoxesByModelResponse, GetMediaCheckBoxesByFranchiseResponse, GetMediumByIdResponse, GetMediumListResponse, MediumFull } from '../../interfaces/franchise';
import { BaseResponse } from '../../interfaces/base-response';
import { RelationsMoodTagForm, RelationsMoodArtistForm, RelationsMoodModelForm, CheckRelationsArtistStyleByArtistResponse, CheckRelationsArtistStyleByStyleResponse } from '../../interfaces/relations';
import { GetOneVideoDetailsResponse } from '../../interfaces/mood-video';
import { GetOneImageDetailsResponse } from '../../interfaces/mood-image';
import { GetOneVideoYoutubeDetailsResponse } from '../../interfaces/mood-video-youtube';
import { MultiTagsForm } from '../../interfaces/forms-update';
import { GetAllTagCategoriesResponse, TagCategoryFull, GetTagCategoryByIdResponse } from '../../interfaces/tag-category';
import { TagsGetFullListResponse, GetTagsCheckBoxesByMoodResponse } from '../../interfaces/tags-list';
import { GetAllStylesResponse, GetStyleByIdResponse, GetStylesCheckBoxesByArtistResponse, StyleFull } from '../../interfaces/style';
import { NotificationService } from '../notification.service';

@Injectable({
  providedIn: 'root'
})

export class FlowService {
  #http = inject(HttpClient)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  #moodId = new BehaviorSubject<number | null>(null)
  public updateMoodId(moodId: number | null) { this.#moodId.next(moodId) }
  #tagId = new BehaviorSubject<number | null>(null)
  public updateTagId(tagId: number | null) { this.#tagId.next(tagId); this.#moodsGalleryType.next('tag') }
  #tagCategoryId = new BehaviorSubject<number | null>(null)
  public updateTagCategoryId(tagCategoryId: number | null) { this.#tagCategoryId.next(tagCategoryId) }
  #modelId = new BehaviorSubject<number | null>(null)
  public updateModelId(modelId: number | null) { this.#modelId.next(modelId); this.#moodsGalleryType.next('model') }
  #artistId = new BehaviorSubject<number | null>(null)
  public updateArtistId(artistId: number | null) { this.#artistId.next(artistId); this.#moodsGalleryType.next('artist') }
  #styleId = new BehaviorSubject<number | null>(null)
  public updateStyleId(styleId: number | null) { this.#styleId.next(styleId) }
  #franchiseId = new BehaviorSubject<number | null>(null)
  public updateFranchiseId(franchiseId: number | null) { this.#franchiseId.next(franchiseId); this.#moodsGalleryType.next('franchise') }
  #mediumId = new BehaviorSubject<number | null>(null)
  public updateMediumId(mediumId: number | null) { this.#mediumId.next(mediumId) }
  #linkId = new BehaviorSubject<number | null>(null)
  public updateLinkId(linkId: number | null) { this.#linkId.next(linkId) }
  #linkCategoryId = new BehaviorSubject<number | null>(null)
  public updateLinkCategoryId(linkCategoryId: number | null) { this.#linkCategoryId.next(linkCategoryId) }
  #moodsGalleryType = new BehaviorSubject<string>('all')
  public updateMoodsGalleryType(moodsGalleryType: string) { this.#moodsGalleryType.next(moodsGalleryType) }
  moodsGalleryType$ = this.#moodsGalleryType.asObservable()

  // Refresh triggers.
  #refreshMoods = new Subject<void>()
  public refreshMoods() { this.#refreshMoods.next() }
  #refreshTagCategories = new BehaviorSubject<boolean>(true)
  public refreshTagCategories() { this.#refreshTagCategories.next(true) }
  #refreshTags = new BehaviorSubject<boolean>(true)
  public refreshTags() { this.#refreshTags.next(true) }
  #refreshModels = new BehaviorSubject<boolean>(true)
  public refreshModels() { this.#refreshModels.next(true) }
  #refreshStyles = new BehaviorSubject<boolean>(true)
  public refreshStyles() { this.#refreshStyles.next(true) }
  #refreshArtists = new BehaviorSubject<boolean>(true)
  public refreshArtists() { this.#refreshArtists.next(true) }
  #refreshMedia = new BehaviorSubject<boolean>(true)
  public refreshMedia() { this.#refreshMedia.next(true) }
  #refreshFranchises = new BehaviorSubject<boolean>(true)
  public refreshFranchises() { this.#refreshFranchises.next(true) }
  #refreshLinkCategories = new BehaviorSubject<boolean>(true)
  public refreshLinkCategories() { this.#refreshLinkCategories.next(true) }
  #refreshLinks = new BehaviorSubject<boolean>(true)
  public refreshLinks() { this.#refreshLinks.next(true) }

  // Get all.
  moods$ = this.#refreshMoods.pipe(
    startWith(null),
    switchMap(() => this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.moods))
  tags$ = this.#refreshTags.pipe(
    switchMap(() => this.#http.get<GetAllTagsResponse>(`${this.#url}Tags/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.tags))
  tagCategories$ = this.#refreshTagCategories.pipe(
    switchMap(() => this.#http.get<GetAllTagCategoriesResponse>(`${this.#url}TagCategories/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.tagCategories))
  tagsWithCategories$ = this.#refreshTags.pipe(
    switchMap(() => this.#http.get<TagsGetFullListResponse>(this.#url + 'Tags/GetTagsList')),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.categoriesWithTags))
  artists$ = this.#refreshArtists.pipe(
    switchMap(() => this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.artists))
  styles$ = this.#refreshStyles.pipe(
    switchMap(() => this.#http.get<GetAllStylesResponse>(`${this.#url}Styles/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.styles))
  models$ = this.#refreshModels.pipe(
    switchMap(() => this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.models))
  franchises$ = this.#refreshFranchises.pipe(
    switchMap(() => this.#http.get<GetAllFranchisesResponse>(`${this.#url}Franchises/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.franchises))
  franchisesWithMedia$ = this.#refreshFranchises.pipe(
    switchMap(() => this.#http.get<GetMediumListResponse>(this.#url + 'Franchises/GetFranchisesList')),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.media))
  media$ = this.#refreshMedia.pipe(
    switchMap(() => this.#http.get<GetAllMediaResponse>(`${this.#url}Media/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.media))
  links$ = this.#refreshLinks.pipe(
    switchMap(() => this.#http.get<GetLinksResponse>(`${this.#url}Links/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.links))
  linkCategories$ = this.#refreshLinkCategories.pipe(
    switchMap(() => this.#http.get<GetLinkCategoriesResponse>(`${this.#url}LinkCategories/GetAll`)),
    tap(response => {
      if (!response.success) this.#notificationService.error(response.message)
    }),
    map(response => response.linkCategories))

  // Get random mood.
  getRandomMood(): Observable<MoodFull> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetailsRandom`).pipe(
      tap(response => {
        if (response.success) {
          this.updateMoodId(response.mood.businessId)
        }
        else this.#notificationService.error(response.message)
      }),
      map(response => response.mood))
  }
  // Get by id.
  mood$ = combineLatest([this.#moodId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([moodId]) => {
        let moodObservable$: Observable<MoodFull>
        if (moodId === null) {
          moodObservable$ = this.getRandomMood()
          this.updateMoodsGalleryType('all')
        }
        else {
          moodObservable$ = this.getMoodById(moodId)
        }

        return moodObservable$.pipe(
          switchMap(mood => {
            if (!mood || mood.businessId == null) {
              return of(undefined)
            }

            let mediaObservable$: Observable<any>

            switch (mood.type) {
              case 1:   // Image.
                mediaObservable$ = this.getImage(mood.businessId).pipe(
                  map(image => ({
                    mediaType: 'Image',
                    width: image.width,
                    height: image.height,
                    size: image.size
                  }))
                );
                break;
              case 2:   // Video.
                mediaObservable$ = this.getVideo(mood.businessId).pipe(
                  map(video => ({
                    mediaType: 'Video',
                    width: video.width,
                    height: video.height,
                    duration: video.duration,
                    size: video.size
                  }))
                );
                break;
              case 4:   // VideoYouTube.
                mediaObservable$ = this.getVideoYoutube(mood.businessId).pipe(
                  map(videoYouTube => ({
                    mediaType: 'VideoYouTube',
                    url: videoYouTube.url
                  }))
                );
                break;
              default:
                mediaObservable$ = of({})
            }

            return combineLatest([
              of(mood),
              mediaObservable$,
              this.getModelsByMood(mood.businessId),
              this.getFranchisesByMood(mood.businessId),
              this.getArtistsByMood(mood.businessId),
              this.getTagsByMood(mood.businessId),

            ]).pipe(
              map(([mood, mediaProps, models, franchises, artists, tags]) => ({
                ...mood,
                ...mediaProps,
                models,
                franchises,
                artists,
                tags
              }))
            )
          })
        )
      }),
      startWith(undefined)
    )
  tag$ = this.#tagId.pipe(
    switchMap(tagId => tagId ? this.getTagById(tagId) : of(undefined)), startWith(undefined))
  tagCategory$ = this.#tagCategoryId.pipe(
    switchMap(tagCategoryId => tagCategoryId ? this.getTagCategoryById(tagCategoryId) : of(undefined)), startWith(undefined))
  model$ = this.#modelId.pipe(
    switchMap(modelId => modelId ? this.getModelById(modelId) : of(undefined)), startWith(undefined))
  artist$ = this.#artistId.pipe(
    switchMap(artistId => artistId ? this.getArtistById(artistId) : of(undefined)), startWith(undefined))
  style$ = this.#styleId.pipe(
    switchMap(styleId => styleId ? this.getStyleById(styleId) : of(undefined)), startWith(undefined))
  franchise$ = this.#franchiseId.pipe(
    switchMap(franchiseId => franchiseId ? this.getFranchiseById(franchiseId) : of(undefined)), startWith(undefined))
  medium$ = this.#mediumId.pipe(
    switchMap(mediumId => mediumId ? this.getMediumById(mediumId) : of(undefined)), startWith(undefined))
  link$ = this.#linkId.pipe(
    switchMap(linkId => linkId ? this.getLinkById(linkId) : of(undefined)), startWith(undefined))
  linkCategory$ = this.#linkCategoryId.pipe(
    switchMap(linkCategoryId => linkCategoryId ? this.getLinkCategoryById(linkCategoryId) : of(undefined)), startWith(undefined))

  // Get by ...
  moodsByTag$ = combineLatest([this.#tagId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([tagId]) => {
        return tagId ? this.getMoodsByTag(tagId) : of([])
      }),
      startWith([])
    )
  moodsByTagCategory$ = combineLatest([this.#tagCategoryId, this.#refreshMoods.pipe(startWith(null))])
  .pipe(
    switchMap(([tagCategoryrId]) => {
      return tagCategoryrId ? this.getMoodsByTagCategory(tagCategoryrId) : of([])
    }),
    startWith([])
  )
  moodsByModel$ = combineLatest([this.#modelId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([modelId]) => {
        return modelId ? this.getMoodsByModel(modelId) : of([])
      }),
      startWith([])
    )
  moodsByArtist$ = combineLatest([this.#artistId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([artistId]) => {
        return artistId ? this.getMoodsByArtist(artistId) : of([])
      }),
      startWith([])
    )
  moodsByFranchise$ = combineLatest([this.#franchiseId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([franchiseId]) => {
        return franchiseId ? this.getMoodsByFranchise(franchiseId) : of([])
      }),
      startWith([])
    )
  tagsByCategory$ = combineLatest([this.#tagCategoryId, this.#refreshTags]).pipe(
    switchMap(([tagCategoryId]) => tagCategoryId != null ? this.getTagsByCategory(tagCategoryId) : this.tags$), startWith([]))
  modelsByFranchise$ = combineLatest([this.#franchiseId, this.#refreshModels]).pipe(
    switchMap(([franchiseId]) => franchiseId != null ? this.getModelsByFranchise(franchiseId) : this.models$), startWith([]))
  artistsByStyle$ = combineLatest([this.#styleId, this.#refreshArtists]).pipe(
    switchMap(([styleId]) => styleId != null ? this.getArtistsByStyle(styleId) : this.artists$), startWith([]))
  franchisesByMedium$ = combineLatest([this.#mediumId, this.#refreshFranchises]).pipe(
    switchMap(([mediumId]) => mediumId != null ? this.getFranchisesByMedium(mediumId) : this.franchises$), startWith([]))
  linksByCategory$ = combineLatest([this.#linkCategoryId, this.#refreshLinks]).pipe(
    switchMap(([linkCategoryId]) => linkCategoryId != null ? this.getLinksByCategory(linkCategoryId) : this.links$), startWith([]))

  public getMoodById(moodId: number): Observable<MoodFull> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetails/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.mood))
  }
  public getTagById(tagId: number): Observable<TagFull> {
    return this.#http.get<GetTagByIdResponse>(`${this.#url}Tags/GetOneDetails/${tagId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tag))
  }
  public getTagCategoryById(tagCategoryId: number): Observable<TagCategoryFull> {
    return this.#http.get<GetTagCategoryByIdResponse>(`${this.#url}TagCategories/GetOneDetails/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagCategory))
  }
  public getModelById(modelId: number): Observable<ModelFull> {
    return this.#http.get<GetModelResponse>(`${this.#url}Models/GetOneDetails/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.model))
  }
  public getArtistById(artistId: number): Observable<ArtistFull> {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artist))
  }
  public getStyleById(styleId: number): Observable<StyleFull> {
    return this.#http.get<GetStyleByIdResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.style))
  }
  public getFranchiseById(franchiseId: number): Observable<FranchiseFull> {
    return this.#http.get<GetFranchiseByIdResponse>(`${this.#url}Franchises/GetOneDetails/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchise))
  }
  public getMediumById(mediumId: number): Observable<MediumFull> {
    return this.#http.get<GetMediumByIdResponse>(`${this.#url}Media/GetOneDetails/${mediumId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.medium))
  }
  public getLinkById(linkId: number): Observable<LinkFull> {
    return this.#http.get<GetLinkResponse>(`${this.#url}Links/GetOneDetails/${linkId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.link))
  }
  public getLinkCategoryById(linkCategoryId: number): Observable<LinkCategoryFull> {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${linkCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.linkCategory))
  }

  public getMoodsByTag(tagId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTag/${tagId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods))
  }
  public getMoodsByTagCategory(tagCategoryId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTagCategory/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods))
  }
  public getMoodsByModel(modelId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByModel/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods))
  }
  public getMoodsByArtist(artistId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByArtist/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods))
  }
  public getMoodsByFranchise(franchiseId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.moods))
  }
  public getTagsByCategory(tagCategoryId: number): Observable<TagLight[]> {
    return this.#http.get<GetTagsByCategoryResponse>(`${this.#url}Tags/GetByCategory/${tagCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tags))
  }
  public getModelsByFranchise(franchiseId: number): Observable<ModelLight[]> {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models))
  }
  public getArtistsByStyle(styleId: number): Observable<ArtistLight[]> {
    return this.#http.get<GetArtistsByStyleResponse>(`${this.#url}Artists/GetByStyle/${styleId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artists))
  }
  public getFranchisesByMedium(mediumId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByMediumResponse>(`${this.#url}Franchises/GetByMedium/${mediumId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchises))
  }
  public getLinksByCategory(linkCategoryId: number): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${linkCategoryId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.links))
  }

  // Get Mood Type.
  public getImage(businessId: number) {
    return this.#http.get<GetOneImageDetailsResponse>(`${this.#url}Images/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.image))
  }
  public getVideo(businessId: number) {
    return this.#http.get<GetOneVideoDetailsResponse>(`${this.#url}Videos/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.video))
  }
  public getVideoYoutube(businessId: number) {
    return this.#http.get<GetOneVideoYoutubeDetailsResponse>(`${this.#url}VideosYouTube/GetOneDetails/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.videoYouTube))
  }

  // Get By Mood.
  public getModelsByMood(businessId: number) {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetByMood/${businessId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models))
  }
  public getFranchisesByMood(moodId: number) {
    return this.#http.get<GetFranchisesByMoodResponse>(`${this.#url}Franchises/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchisesByMood))
  }
  public getArtistsByMood(moodId: number) {
    return this.#http.get<GetArtistsByMoodResponse>(`${this.#url}Artists/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artistsByMood))
  }
  public getTagsByMood(moodId: number) {
    return this.#http.get<GetTagsByMoodResponse>(`${this.#url}Tags/GetByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagsByMood))
  }
  // Get checkboxes.
  public getCommonTagsByMoods(form: CommonTagsByMoodsForm) {
    return this.#http.post<GetCommonTagsByMoodsResponse>(`${this.#url}Moods/GetCommonTagsByMoods`, form).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.commonTags))
  }
  public getTagsCheckBoxByMood(moodId: number) {
    return this.#http.get<GetTagsCheckBoxesByMoodResponse>(`${this.#url}Tags/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.tagsCheckBoxesList))
  }
  public getModelsCheckBoxByMood(moodId: number) {
    return this.#http.get<GetModelsCheckBoxesByMoodResponse>(`${this.#url}Models/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.models))
  }
  public getStylesCheckBoxesByArtist(artistId: number) {
    return this.#http.get<GetStylesCheckBoxesByArtistResponse>(`${this.#url}Styles/GetCheckBoxesByArtist/${artistId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.styles))
  }
  public getArtistsCheckBoxByMood(moodId: number) {
    return this.#http.get<GetArtistsCheckBoxesByMoodResponse>(`${this.#url}Artists/GetCheckBoxesByMood/${moodId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.artists))
  }
  public getMediaCheckBoxesByFranchise(franchiseId: number) {
    return this.#http.get<GetMediaCheckBoxesByFranchiseResponse>(`${this.#url}Media/GetCheckBoxesByFranchise/${franchiseId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.media))
  }
  public getFranchisesCheckBoxesByModel(modelId: number) {
    return this.#http.get<GetFranchisesCheckBoxesByModelResponse>(`${this.#url}Franchises/GetCheckBoxesByModel/${modelId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.franchises))
  }
  public getLinkCategoriesCheckBoxes(linkId: number) {
    return this.#http.get<GetLinkCategoriesCheckBoxesResponse>(`${this.#url}LinkCategories/GetCheckBoxesByLink/${linkId}`).pipe(
      tap(response => {
        if (!response.success) this.#notificationService.error(response.message)
      }),
      map(response => response.linkCategories))
  }

  // Insert Mood Relations.
  public InsertRMT(rmtForm: RelationsMoodTagForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodTag/Create', rmtForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmtForm.moodId)
          this.#notificationService.success(response.message)
        }
        else this.#notificationService.error(response.message)
      }))
  }
  public InsertRMA(rmaForm: RelationsMoodArtistForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodArtist/Create', rmaForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmaForm.moodId)
          this.refreshMoods()
          this.#notificationService.success(response.message)
        }
        else this.#notificationService.error(response.message)
      }))
  }
  public InsertRMM(rmmForm: RelationsMoodModelForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodModel/Create', rmmForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmmForm.moodId)
          this.refreshMoods()
          this.#notificationService.success(response.message)
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public multiTags(form: MultiTagsForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Moods/MultiTags', form).pipe(
      tap(response => {
        if(response.success) {
          this.#notificationService.success(response.message)
        }
      })
    )
  }

  // Check Relations.
  public CheckRelationsArtistStyleByArtist(artistId: number): Observable<CheckRelationsArtistStyleByArtistResponse> {
    return this.#http.get<CheckRelationsArtistStyleByArtistResponse>(this.#url + 'Relations/ArtistStyle/CheckRelationsByArtist?artistId=' + artistId)
  }
  public CheckRelationsArtistStyleByStyle(styleId: number): Observable<CheckRelationsArtistStyleByStyleResponse> {
    return this.#http.get<CheckRelationsArtistStyleByStyleResponse>(this.#url + 'Relations/ArtistStyle/CheckRelationsByStyle?styleId=' + styleId)
  }

  private calculateIndexes(moods: MoodLight[], selectedMoodId: number | null) {
    const currentIndex = selectedMoodId !== null ? moods.findIndex(m => m.businessId === selectedMoodId) : -1
    const previousMoodId = currentIndex > 0 ? moods[currentIndex - 1]?.businessId : moods.length ? moods[moods.length - 1]?.businessId : null
    const nextMoodId = currentIndex >= 0 && currentIndex < moods.length - 1 ? moods[currentIndex + 1]?.businessId : moods.length ? moods[0]?.businessId : null
    return { currentIndex, previousMoodId, nextMoodId }
  }

  private flow$ = combineLatest([
    this.moodsGalleryType$,
    this.mood$,
    this.moods$,
    this.moodsByTag$,
    this.moodsByTagCategory$,
    this.moodsByModel$,
    this.moodsByArtist$,
    this.moodsByFranchise$,
    this.tag$,
    this.tags$,
    this.tagCategory$,
    this.tagsByCategory$,
    this.tagCategories$,
    this.tagsWithCategories$,
    this.artist$,
    this.artists$,
    this.artistsByStyle$,
    this.model$,
    this.models$,
    this.modelsByFranchise$,
    this.style$,
    this.styles$,
    this.franchise$,
    this.franchises$,
    this.franchisesByMedium$,
    this.medium$,
    this.media$,
    this.franchisesWithMedia$,
    this.link$,
    this.links$,
    this.linkCategory$,
    this.linksByCategory$,
    this.linkCategories$,
    combineLatest([this.moods$, this.#moodId]).pipe(map(([moods, moodId]) => this.calculateIndexes(moods, moodId))),
    combineLatest([this.moodsByArtist$, this.#moodId]).pipe(map(([moodsByArtist, moodId]) => this.calculateIndexes(moodsByArtist, moodId))),
    combineLatest([this.moodsByModel$, this.#moodId]).pipe(map(([moodsByModel, moodId]) => this.calculateIndexes(moodsByModel, moodId))),
    combineLatest([this.moodsByTag$, this.#moodId]).pipe(map(([moodsByTag, moodId]) => this.calculateIndexes(moodsByTag, moodId))),
    combineLatest([this.moodsByTagCategory$, this.#moodId]).pipe(map(([moodsByTagCategory, moodId]) => this.calculateIndexes(moodsByTagCategory, moodId))),
    combineLatest([this.moodsByFranchise$, this.#moodId]).pipe(map(([moodsByFranchise, moodId]) => this.calculateIndexes(moodsByFranchise, moodId))),
  ]).pipe(
    map(([
      moodsGalleryType,
      mood,
      moods,
      moodsByTag,
      moodsByTagCategory,
      moodsByModel,
      moodsByArtist,
      moodsByFranchise,
      tag,
      tags,
      tagCategory,
      tagsByCategory,
      tagCategories,
      tagsWithCategories,
      artist,
      artists,
      artistsByStyle,
      model,
      models,
      modelsByFranchise,
      style,
      styles,
      franchise,
      franchises,
      franchisesByMedium,
      medium,
      media,
      franchisesWithMedia,
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories,
      moodsIndexes,
      moodsByArtistIndexes,
      moodsByModelIndexes,
      moodsByTagIndexes,
      moodsByTagCategoryIndexes,
      moodsByFranchiseIndexes
    ]) => ({
      moodsGalleryType,
      mood,
      moods,
      moodsByTag,
      moodsByTagCategory,
      moodsByModel,
      moodsByArtist,
      moodsByFranchise,
      tag,
      tags,
      tagCategory,
      tagsByCategory,
      tagCategories,
      tagsWithCategories,
      artist,
      artists,
      artistsByStyle,
      model,
      models,
      modelsByFranchise,
      style,
      styles,
      franchise,
      franchises,
      franchisesByMedium,
      medium,
      media,
      franchisesWithMedia,
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories,
      moodsIndexes,
      moodsByArtistIndexes,
      moodsByModelIndexes,
      moodsByTagIndexes,
      moodsByTagCategoryIndexes,
      moodsByFranchiseIndexes
    }))
  )
  public flow = toSignal(this.flow$)
}