import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable, map, of, combineLatest, BehaviorSubject, switchMap, startWith, Subject, take, tap } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetMoodResponse, GetMoodsResponse, MoodFull, MoodLight } from '../models/mood';
import { GetAllTagsResponse, GetTagByIdResponse, GetTagsByCategoryResponse, GetTagsByMoodResponse, TagFull, TagLight } from '../models/tag';
import { ArtistFull, ArtistLight, GetAllArtistsResponse, GetArtistByIdResponse, GetArtistsByMoodResponse, GetArtistsByStyleResponse, GetArtistsCheckBoxesByMoodResponse } from '../models/artist';
import { CreateModelResponse, GetAllModelsResponse, GetModelResponse, GetModelsCheckBoxesByMoodResponse, ModelFull, ModelLight } from '../models/model';
import { GetLinkCategoriesCheckBoxesResponse, GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, GetLinksResponse, LinkCategoryFull, LinkFull, LinkLight } from '../models/link';
import { FranchiseFull, FranchiseLight, GetFranchiseResponse, GetFranchisesByMediaResponse, GetFranchisesByMoodResponse, GetFranchisesResponse, GetMediaResponse, GetMediasListResponse, GetMediasResponse, MediaFull } from '../models/franchise';
import { BaseResponse } from '../models/base-response';
import { RelationsMoodTagForm, RelationsMoodArtistForm, RelationsMoodModelForm, RelationsArtistStyleForm, CheckRelationsArtistStyleByArtistResponse, CheckRelationsArtistStyleByStyleResponse } from '../models/relations';
import { CreateMoodVideoResponse, GetOneVideoDetailsResponse, VideoForm } from '../models/mood-video';
import { CreateMoodImageResponse, GetOneImageDetailsResponse, ImageForm } from '../models/mood-image';
import { GetOneVideoYoutubeDetailsResponse } from '../models/mood-video-youtube';
import { ArtistUpdateForm, FranchiseUpdateForm, LinkCategoryUpdateForm, LinkUpdateForm, MediaUpdateForm, ModelUpdateForm, MoodScoreUpdate, MoodUpdateForm, StyleUpdateForm, TagCategoryUpdateForm, TagUpdateForm, UserUpdateForm } from '../models/forms-update';
import { CreateArtistResponse, CreateFranchiseResponse, CreateLinkCategoryResponse, CreateLinkResponse, CreateMediaResponse, CreateMoodResponse, CreateStyleResponse, CreateTagCategoryResponse, CreateTagResponse, CreateUserResponse } from '../models/responses-create';
import { ArtistCreateForm, FranchiseCreateForm, LinkCategoryCreateForm, LinkCreateForm, MediaCreateForm, ModelCreateForm, MoodCreateForm, StyleCreateForm, TagCategoryCreateForm, TagCreateForm, UserCreateForm } from '../models/forms-create';
import { GetAllTagCategoriesResponse, TagCategoryFull, GetTagCategoryByIdResponse } from '../models/tag-category';
import { TagsGetFullListResponse, GetTagsCheckBoxesByMoodResponse } from '../models/tags-list';
import { GetAllStylesResponse, GetStyleByIdResponse, StyleFull } from '../models/style';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class FlowService {
  #http = inject(HttpClient)
  #toastr = inject(ToastrService)
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
  #mediaId = new BehaviorSubject<number | null>(null)
  public updateMediaId(mediaId: number | null) { this.#mediaId.next(mediaId) }
  #linkId = new BehaviorSubject<number | null>(null)
  public updateLinkId(linkId: number | null) { this.#linkId.next(linkId) }
  #linkCategoryId = new BehaviorSubject<number | null>(null)
  public updateLinkCategoryId(linkCategoryId: number | null) { this.#linkCategoryId.next(linkCategoryId) }
  #userId = new BehaviorSubject<number | null>(null)
  public updateUserId(userId: number | null) { this.#userId.next(userId) }
  #moodsGalleryType = new BehaviorSubject<string>('all')
  public updateMoodsGalleryType(moodsGalleryType: string) { this.#moodsGalleryType.next(moodsGalleryType) }
  moodsGalleryType$ = this.#moodsGalleryType.asObservable()

  // Refresh Triggers.
  #refreshMoods = new Subject<void>()
  public refreshMoods() { this.#refreshMoods.next() }
  #refreshArtists = new BehaviorSubject<boolean>(true)
  public refreshArtists() { this.#refreshArtists.next(true) }
  #refreshStyles = new BehaviorSubject<boolean>(true)
  public refreshStyles() { this.#refreshStyles.next(true) }
  #refreshModels = new BehaviorSubject<boolean>(true)
  public refreshModels() { this.#refreshModels.next(true) }
  #refreshFranchises = new BehaviorSubject<boolean>(true)
  public refreshFranchises() { this.#refreshFranchises.next(true) }
  #refreshMedias = new BehaviorSubject<boolean>(true)
  public refreshMedias() { this.#refreshMedias.next(true) }
  #refreshLinks = new BehaviorSubject<boolean>(true)
  public refreshLinks() { this.#refreshLinks.next(true) }
  #refreshLinkCategories = new BehaviorSubject<boolean>(true)
  public refreshLinkCategories() { this.#refreshLinkCategories.next(true) }
  #refreshTags = new BehaviorSubject<boolean>(true)
  public refreshTags() { this.#refreshTags.next(true) }
  #refreshTagCategories = new BehaviorSubject<boolean>(true)
  public refreshTagCategories() { this.#refreshTagCategories.next(true) }
  #refreshUsers = new BehaviorSubject<boolean>(true)
  public refreshUsers() { this.#refreshUsers.next(true) }

  // Get All.
  moods$ = this.#refreshMoods.pipe(
    startWith(null),
    switchMap(() => this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetAll`)),
    map(response => response.moods))
  tags$ = this.#refreshTags.pipe(
    switchMap(() => this.#http.get<GetAllTagsResponse>(`${this.#url}Tags/GetAll`)),
    map(response => response.tags))
  tagCategories$ = this.#refreshTagCategories.pipe(
    switchMap(() => this.#http.get<GetAllTagCategoriesResponse>(`${this.#url}TagCategories/GetAll`)),
    map(response => response.tagCategories))
  tagsWithCategories$ = this.#refreshTags.pipe(
    switchMap(() => this.#http.get<TagsGetFullListResponse>(this.#url + 'Tags/GetTagsList')),
    map(response => response.categoriesWithTags))
  artists$ = this.#refreshArtists.pipe(
    switchMap(() => this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`)),
    map(response => response.artists))
  styles$ = this.#refreshStyles.pipe(
    switchMap(() => this.#http.get<GetAllStylesResponse>(`${this.#url}Styles/GetAll`)),
    map(response => response.styles))
  models$ = this.#refreshModels.pipe(
    switchMap(() => this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`)),
    map(response => response.models))
  franchises$ = this.#refreshFranchises.pipe(
    switchMap(() => this.#http.get<GetFranchisesResponse>(`${this.#url}Franchises/GetAll`)),
    map(response => response.franchises))
  franchisesWithMedias$ = this.#http.get<GetMediasListResponse>(this.#url + 'Franchises/GetFranchisesList').pipe(
    map(response => response.medias))
  medias$ = this.#http.get<GetMediasResponse>(`${this.#url}Medias/GetAll`).pipe(map(response => response.medias))
  links$ = this.#refreshLinks.pipe(
    switchMap(() => this.#http.get<GetLinksResponse>(`${this.#url}Links/GetAll`)),
    map(response => response.links))
  linkCategories$ = this.#http.get<GetLinkCategoriesResponse>(`${this.#url}LinkCategories/GetAll`).pipe(
    map(response => response.linkCategories))

  // Get Random Mood
  getRandomMood(): Observable<MoodFull> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetailsRandom`).pipe(map(response => response.mood))
  }
  // Get By ID.
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
              case 1:   // Image
                mediaObservable$ = this.getImage(mood.businessId).pipe(
                  map(image => ({
                    mediaType: 'Image',
                    width: image.width,
                    height: image.height,
                    size: image.size
                  }))
                );
                break;
              case 2:   // Video
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
              case 4:   // VideoYouTube
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

  tag$ = this.#tagId.pipe(switchMap(tagId => tagId ? this.getTagById(tagId) : of(undefined)), startWith(undefined))
  tagCategory$ = this.#tagCategoryId.pipe(
    switchMap(tagCategoryId => tagCategoryId ? this.getTagCategoryById(tagCategoryId) : of(undefined)), startWith(undefined))
  model$ = this.#modelId.pipe(switchMap(modelId => modelId ? this.getModelById(modelId) : of(undefined)), startWith(undefined))
  artist$ = this.#artistId.pipe(switchMap(artistId => artistId ? this.getArtistById(artistId) : of(undefined)), startWith(undefined))
  style$ = this.#styleId.pipe(switchMap(styleId => styleId ? this.getStyleById(styleId) : of(undefined)), startWith(undefined))
  franchise$ = this.#franchiseId.pipe(switchMap(franchiseId => franchiseId ? this.getFranchiseById(franchiseId) : of(undefined)), startWith(undefined))
  media$ = this.#mediaId.pipe(switchMap(mediaId => mediaId ? this.getMediaById(mediaId) : of(undefined)), startWith(undefined))
  link$ = this.#linkId.pipe(switchMap(linkId => linkId ? this.getLinkById(linkId) : of(undefined)), startWith(undefined))
  linkCategory$ = this.#linkCategoryId.pipe(
    switchMap(linkCategoryId => linkCategoryId ? this.getLinkCategoryById(linkCategoryId) : of(undefined)), startWith(undefined))

  moodsByTag$ = combineLatest([this.#tagId, this.#refreshMoods.pipe(startWith(null))])
    .pipe(
      switchMap(([tagId]) => {
        return tagId ? this.getMoodsByTag(tagId) : of([])
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

  tagsByCategory$ = this.#tagCategoryId.pipe(
    switchMap(tagCategoryId => tagCategoryId != null ? this.getTagsByCategory(tagCategoryId) : this.tags$), startWith([]))
  modelsByFranchise$ = this.#franchiseId.pipe(
    switchMap(franchiseId => franchiseId != null ? this.getModelsByFranchise(franchiseId) : this.models$), startWith([]))
  artistsByStyle$ = this.#styleId.pipe(
    switchMap(styleId => styleId != null ? this.getArtistsByStyle(styleId) : this.artists$), startWith([]))
  franchisesByMedia$ = this.#mediaId.pipe(
    switchMap(mediaId => mediaId != null ? this.getFranchisesByMedia(mediaId) : this.franchises$), startWith([]))
  linksByCategory$ = this.#linkCategoryId.pipe(
    switchMap(linkCategoryId => linkCategoryId != null ? this.getLinksByCategory(linkCategoryId) : this.links$), startWith([]))

  public getMoodById(moodId: number): Observable<MoodFull> {
    return this.#http.get<GetMoodResponse>(`${this.#url}Moods/GetOneDetails/${moodId}`).pipe(
      map(response => response.mood))
  }
  public getTagById(tagId: number): Observable<TagFull> {
    return this.#http.get<GetTagByIdResponse>(`${this.#url}Tags/GetOneDetails/${tagId}`).pipe(
      map(response => response.tag))
  }
  public getTagCategoryById(tagCategoryId: number): Observable<TagCategoryFull> {
    return this.#http.get<GetTagCategoryByIdResponse>(`${this.#url}TagCategories/GetOneDetails/${tagCategoryId}`).pipe(
      map(response => response.tagCategory))
  }
  public getModelById(modelId: number): Observable<ModelFull> {
    return this.#http.get<GetModelResponse>(`${this.#url}Models/GetOneDetails/${modelId}`).pipe(
      map(response => response.model))
  }
  public getArtistById(artistId: number): Observable<ArtistFull> {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(
      map(response => response.artist))
  }
  public getStyleById(styleId: number): Observable<StyleFull> {
    return this.#http.get<GetStyleByIdResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(
      map(response => response.style))
  }
  public getFranchiseById(franchiseId: number): Observable<FranchiseFull> {
    return this.#http.get<GetFranchiseResponse>(`${this.#url}Franchises/GetOneDetails/${franchiseId}`).pipe(
      map(response => response.franchise))
  }
  public getMediaById(mediaId: number): Observable<MediaFull> {
    return this.#http.get<GetMediaResponse>(`${this.#url}Medias/GetOneDetails/${mediaId}`).pipe(
      map(response => response.media))
  }
  public getLinkById(linkId: number): Observable<LinkFull> {
    return this.#http.get<GetLinkResponse>(`${this.#url}Links/GetOneDetails/${linkId}`).pipe(
      map(response => response.link))
  }
  public getLinkCategoryById(linkCategoryId: number): Observable<LinkCategoryFull> {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${linkCategoryId}`).pipe(
      map(response => response.linkCategory))
  }

  public getMoodsByTag(tagId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTag/${tagId}`).pipe(
      map(response => response.moods))
  }
  public getMoodsByModel(modelId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByModel/${modelId}`).pipe(
      map(response => response.moods))
  }
  public getMoodsByArtist(artistId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByArtist/${artistId}`).pipe(
      map(response => response.moods))
  }
  public getMoodsByFranchise(franchiseId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByFranchise/${franchiseId}`).pipe(
      map(response => response.moods))
  }
  public getTagsByCategory(tagCategoryId: number): Observable<TagLight[]> {
    return this.#http.get<GetTagsByCategoryResponse>(`${this.#url}Tags/GetByCategory/${tagCategoryId}`).pipe(
      map(response => response.tags))
  }
  public getModelsByFranchise(franchiseId: number): Observable<ModelLight[]> {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetByFranchise/${franchiseId}`).pipe(
      map(response => response.models))
  }
  public getArtistsByStyle(styleId: number): Observable<ArtistLight[]> {
    return this.#http.get<GetArtistsByStyleResponse>(`${this.#url}Artists/GetByStyle/${styleId}`).pipe(
      map(response => response.artists))
  }
  public getFranchisesByMedia(mediaId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByMediaResponse>(`${this.#url}Franchises/GetByMedia/${mediaId}`).pipe(
      map(response => response.franchises))
  }
  public getLinksByCategory(linkCategoryId: number): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${linkCategoryId}`).pipe(
      map(response => response.links))
  }

  // Get Mood Type.
  public getImage(businessId: number) {
    return this.#http.get<GetOneImageDetailsResponse>(`${this.#url}Images/GetOneDetails/${businessId}`).pipe(
      map(response => response.image))
  }
  public getVideo(businessId: number) {
    return this.#http.get<GetOneVideoDetailsResponse>(`${this.#url}Videos/GetOneDetails/${businessId}`).pipe(
      map(response => response.video))
  }
  public getVideoYoutube(businessId: number) {
    return this.#http.get<GetOneVideoYoutubeDetailsResponse>(`${this.#url}VideosYouTube/GetOneDetails/${businessId}`).pipe(
      map(response => response.videoYouTube))
  }

  // Get By Mood.
  public getModelsByMood(businessId: number) {
    return this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetByMood/${businessId}`).pipe(
      map(response => response.models))
  }
  public getFranchisesByMood(businessId: number) {
    return this.#http.get<GetFranchisesByMoodResponse>(`${this.#url}Franchises/GetByMood/${businessId}`).pipe(
      map(response => response.franchisesByMood))
  }
  public getArtistsByMood(businessId: number) {
    return this.#http.get<GetArtistsByMoodResponse>(`${this.#url}Artists/GetByMood/${businessId}`).pipe(
      map(response => response.artistsByMood))
  }
  public getTagsByMood(businessId: number) {
    return this.#http.get<GetTagsByMoodResponse>(`${this.#url}Tags/GetByMood/${businessId}`).pipe(
      map(response => response.tagsByMood))
  }
  // Checkboxes.
  public getTagsCheckBoxByMood(businessId: number) {
    return this.#http.get<GetTagsCheckBoxesByMoodResponse>(`${this.#url}Tags/GetCheckBoxesByMood/${businessId}`).pipe(
      map(response => response.tagsCheckBoxesList))
  }
  public getArtistsCheckBoxByMood(businessId: number) {
    return this.#http.get<GetArtistsCheckBoxesByMoodResponse>(`${this.#url}Artists/GetCheckBoxesByMood/${businessId}`).pipe(
      map(response => response.artists))
  }
  public getModelsCheckBoxByMood(businessId: number) {
    return this.#http.get<GetModelsCheckBoxesByMoodResponse>(`${this.#url}Models/GetCheckBoxesByMood/${businessId}`).pipe(
      map(response => response.models))
  }
  public getLinkCategoriesCheckBoxes(linkId: number) {
    return this.#http.get<GetLinkCategoriesCheckBoxesResponse>(`${this.#url}Links/GetCheckBoxesByLink/${linkId}`).pipe(
    tap(response => {
      if(response.success) {
        this.#toastr.success(response.message)
      }
      else this.#toastr.error(response.message)
    }),
    map(response => response.linkCategories))
  }

  // Insert Relations.
  public InsertRMT(rmtForm: RelationsMoodTagForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodTag/Create', rmtForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmtForm.moodId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public InsertRMA(rmaForm: RelationsMoodArtistForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodArtist/Create', rmaForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmaForm.moodId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public InsertRMM(rmmForm: RelationsMoodModelForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodModel/Create', rmmForm).pipe(
      tap((response) => {
        if (response.success) {
          this.updateMoodId(rmmForm.moodId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public InsertRAS(rasForm: RelationsArtistStyleForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/ArtistStyle/Create', rasForm).pipe(
      tap(response => {
        if (response.success) {
          this.updateArtistId(rasForm.artistId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }

  // Check Relations.
  public CheckRelationsArtistStyleByArtist(artistId: number): Observable<CheckRelationsArtistStyleByArtistResponse> {
    return this.#http.get<CheckRelationsArtistStyleByArtistResponse>(this.#url + 'Relations/ArtistStyle/CheckRelationsByArtist?artistId=' + artistId)
  }
  public CheckRelationsArtistStyleByStyle(styleId: number): Observable<CheckRelationsArtistStyleByStyleResponse> {
    return this.#http.get<CheckRelationsArtistStyleByStyleResponse>(this.#url + 'Relations/ArtistStyle/CheckRelationsByStyle?styleId=' + styleId)
  }

  // Create.
  public CreateMood(form: MoodCreateForm) {
    return this.#http.post<CreateMoodResponse>(`${this.#url}Moods/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.refreshMoods()
          this.updateMoodId(response.moodId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateImage(form: ImageForm) {
    return this.#http.post<CreateMoodImageResponse>(`${this.#url}Moods/CreateMoodImage`, form).pipe(
      tap(response => {
        if (response.success) {
          this.refreshMoods()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateVideo(form: VideoForm) {
    return this.#http.post<CreateMoodVideoResponse>(`${this.#url}Moods/CreateMoodVideo`, form).pipe(
      tap(response => {
        if (response.success) {
          this.refreshMoods()
          this.updateMoodId(response.moodId)
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateTagCategory(form: TagCategoryCreateForm) {
    return this.#http.post<CreateTagCategoryResponse>(`${this.#url}TagCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagCategoryId(response.tagCategoryId)
          this.refreshTagCategories()
          this.refreshMoods()
          this.#toastr.success(response.message)
        }
        else {
          this.#toastr.error(response.message)
        }
      }))
  }
  public CreateTag(form: TagCreateForm) {
    return this.#http.post<CreateTagResponse>(`${this.#url}Tags/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagId(response.tagId)
          this.updateTagCategoryId(form.tagCategoryId)
          this.refreshTags()
          this.refreshMoods()
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateModel(form: ModelCreateForm) {
    return this.#http.post<CreateModelResponse>(`${this.#url}Models/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateModelId(response.modelId)
          this.refreshModels()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateStyle(form: StyleCreateForm) {
    return this.#http.post<CreateStyleResponse>(`${this.#url}Styles/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateStyleId(response.styleId)
          this.refreshStyles()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateArtist(formGroup: ArtistCreateForm): Observable<CreateArtistResponse> {
    let styleIds: number[] = formGroup.styles.filter(style => style.isChecked).map(style => style.businessId)
    let createForm: ArtistCreateForm = { name: formGroup.name, description: formGroup.description, styles: [] }

    return this.#http.post<CreateArtistResponse>(`${this.#url}Artists/Create`, createForm).pipe(
      switchMap(response => {
        this.updateArtistId(response.artistId)
        this.refreshArtists()

        if (styleIds.length > 0) {
          let rasForm: RelationsArtistStyleForm = { artistId: response.artistId, styleIds: styleIds }
          return this.InsertRAS(rasForm).pipe(
            map(() => response)
          )
        }
        return of(response)
      })
    )
  }
  public CreateMedia(form: MediaCreateForm) {
    return this.#http.post<CreateMediaResponse>(`${this.#url}Medias/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateMediaId(response.mediaId)
          this.refreshMedias()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateFranchise(form: FranchiseCreateForm) {
    return this.#http.post<CreateFranchiseResponse>(`${this.#url}Franchises/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateFranchiseId(response.franchiseId)
          this.refreshFranchises()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public CreateLinkCategory(form: LinkCategoryCreateForm) {
    return this.#http.post<CreateLinkCategoryResponse>(`${this.#url}LinkCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(response.linkCategoryId)
          this.refreshLinkCategories()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      })
    )
  }
  public CreateLink(form: LinkCreateForm) {
    let categories : number[]
    form.linkCategories.forEach(category => {
      categories.push(category)  
    })
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(response.linkId)
          this.refreshLinks()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      })
    )
  }
  public CreateUser(form: UserCreateForm) {
    return this.#http.post<CreateUserResponse>(`${this.#url}Users/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateUserId(response.userId)
          this.refreshUsers()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      })
    )
  }

  // Update.
  public UpdateMood(form: MoodUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Moods/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.refreshMoods()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public updateScore(form: MoodScoreUpdate): void {
    this.#http.put<BaseResponse>(`${this.#url}Moods/UpdateScore`, form).pipe(
      take(1),
      tap(response => {
        if (response.success) {
          this.refreshMoods()
          this.updateMoodId(form.businessId)
        }
      }),
    ).subscribe()
  }
  public UpdateTagCategory(form: TagCategoryUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}TagCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagCategoryId(form.tagCategoryId)
          this.refreshTagCategories()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateTag(form: TagUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Tags/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagId(form.tagId)
          this.updateTagCategoryId(form.tagCategoryId)
          this.refreshTags()
          this.refreshTagCategories()
          this.refreshMoods()
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateModel(form: ModelUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Models/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateModelId(form.modelId)
          this.refreshModels()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateStyle(form: StyleUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Styles/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateStyleId(form.styleId)
          this.refreshStyles()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateArtist(form: ArtistUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Artists/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateArtistId(form.artistId)
          this.refreshArtists()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateMedia(form: MediaUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Media/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateMediaId(form.mediaId)
          this.refreshMedias()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateFranchise(form: FranchiseUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Franchises/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateFranchiseId(form.franchiseId)
          this.refreshFranchises()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateLinkCategory(form: LinkCategoryUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}LinkCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(form.linkCategoryId)
          this.refreshLinkCategories()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateLink(form: LinkUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(form.linkId)
          this.refreshLinks()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public UpdateUser(form: UserUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Users/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.updateUserId(form.userId)
          this.refreshUsers()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }

  // Delete.
  public DeleteMood(moodId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Moods/Delete/${moodId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateMoodId(null)
          this.refreshMoods()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteTagCategory(tagCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}TagCategories/Delete/${tagCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagId(null)
          this.updateTagCategoryId(null)
          this.refreshTags()
          this.refreshTagCategories()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteTag(tagId: number, tagCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Tags/Delete/${tagId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateTagId(null)
          this.updateTagCategoryId(tagCategoryId)
          this.refreshTags()
          this.refreshTagCategories()
          this.refreshMoods()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteModel(modelId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Models/Delete/${modelId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateModelId(null)
          this.refreshModels()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteStyle(styleId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Styles/Delete/${styleId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateStyleId(null)
          this.refreshStyles()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteArtist(artistId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Artists/Delete/${artistId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateArtistId(null)
          this.refreshArtists()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteMedia(mediaId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Medias/Delete/${mediaId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateMediaId(null)
          this.refreshMedias()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteFranchise(franchiseId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Franchises/Delete/${franchiseId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateFranchiseId(null)
          this.refreshFranchises()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteLinkCategory(linkCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}LinkCategories/Delete/${linkCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkCategoryId(null)
          this.refreshLinkCategories()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteLink(linkId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Links/Delete/${linkId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateLinkId(null)
          this.refreshLinks()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }
  public DeleteUser(userId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Users/Delete/${userId}`).pipe(
      tap(response => {
        if (response.success) {
          this.updateUserId(null)
          this.refreshUsers()
          this.#toastr.success(response.message)
        }
        else this.#toastr.error(response.message)
      }))
  }

  private calculateIndexes(moods: MoodLight[], selectedMoodId: number | null) {
    const currentIndex = selectedMoodId !== null ? moods.findIndex(m => m.businessId === selectedMoodId) : -1;
    const previousMoodId = currentIndex > 0 ? moods[currentIndex - 1]?.businessId : moods.length ? moods[moods.length - 1]?.businessId : null;
    const nextMoodId = currentIndex >= 0 && currentIndex < moods.length - 1 ? moods[currentIndex + 1]?.businessId : moods.length ? moods[0]?.businessId : null;
    return { currentIndex, previousMoodId, nextMoodId };
  }

  private flow$ = combineLatest([
    this.moodsGalleryType$,
    this.mood$,
    this.moods$,
    this.moodsByTag$,
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
    this.franchisesByMedia$,
    this.media$,
    this.medias$,
    this.franchisesWithMedias$,
    this.link$,
    this.links$,
    this.linkCategory$,
    this.linksByCategory$,
    this.linkCategories$,
    combineLatest([this.moods$, this.#moodId]).pipe(map(([moods, moodId]) => this.calculateIndexes(moods, moodId))),
    combineLatest([this.moodsByArtist$, this.#moodId]).pipe(map(([moodsByArtist, moodId]) => this.calculateIndexes(moodsByArtist, moodId))),
    combineLatest([this.moodsByModel$, this.#moodId]).pipe(map(([moodsByModel, moodId]) => this.calculateIndexes(moodsByModel, moodId))),
    combineLatest([this.moodsByTag$, this.#moodId]).pipe(map(([moodsByTag, moodId]) => this.calculateIndexes(moodsByTag, moodId))),
    combineLatest([this.moodsByFranchise$, this.#moodId]).pipe(map(([moodsByFranchise, moodId]) => this.calculateIndexes(moodsByFranchise, moodId))),
  ]).pipe(
    map(([
      moodsGalleryType,
      mood,
      moods,
      moodsByTag,
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
      franchisesByMedia,
      media,
      medias,
      franchisesWithMedias,
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories,
      moodsIndexes,
      moodsByArtistIndexes,
      moodsByModelIndexes,
      moodsByTagIndexes,
      moodsByFranchiseIndexes
    ]) => ({
      moodsGalleryType,
      mood,
      moods,
      moodsByTag,
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
      franchisesByMedia,
      media,
      medias,
      franchisesWithMedias,
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories,
      moodsIndexes,
      moodsByArtistIndexes,
      moodsByModelIndexes,
      moodsByTagIndexes,
      moodsByFranchiseIndexes
    }))
  )
  public flow = toSignal(this.flow$)
}