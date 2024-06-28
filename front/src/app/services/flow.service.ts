import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable, map, of, combineLatest, BehaviorSubject, switchMap, startWith, Subject, take, tap } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetMoodByIdResponse, GetMoodsResponse, MoodFull, MoodLight, MoodUpdateForm, MoodUpdateResponse, UpdateMoodScoreCall, UpdateMoodScoreResponse } from '../models/mood';
import { GetAllTagCategoriesResponse, GetAllTagsResponse, GetTagByIdResponse, GetTagCategoryByIdResponse, GetTagsByCategoryResponse, TagCategoryFull, TagFull, TagLight } from '../models/tag';
import { ArtistFull, ArtistLight, GetAllArtistsResponse, GetArtistByIdResponse, GetArtistsByStyleResponse } from '../models/artist';
import { GetAllModelsResponse, GetModelResponse, GetModelsResponse, ModelFull, ModelLight } from '../models/model';
import { GetLinkCategoriesResponse, GetLinkCategoryResponse, GetLinkResponse, GetLinksResponse, LinkCategoryFull, LinkFull, LinkLight } from '../models/link';
import { GetStyleResponse, GetStylesResponse, StyleFull } from '../models/style';
import { FranchiseFull, FranchiseLight, GetAllFranchisesResponse, GetAllMediasResponse, GetFranchiseByIdResponse, GetFranchisesByMediaResponse, GetMediaByIdResponse, MediaFull } from '../models/franchise';
import { BaseResponse } from '../models/base-response';

@Injectable({
  providedIn: 'root'
})
export class FlowService {
  #http = inject(HttpClient)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  // Subjects
  #moodId = new BehaviorSubject<number | null>(null)
  updateMoodId(moodId: number | null) { this.#moodId.next(moodId) }
  #tagId = new BehaviorSubject<number | null>(null)
  updateTagId(tagId : number | null) { this.#tagId.next(tagId) }
  #tagCategoryId = new BehaviorSubject<number | null>(null)
  updateTagCategoryId(tagCategoryId: number | null) { this.#tagCategoryId.next(tagCategoryId) }
  #modelId = new BehaviorSubject<number | null>(null)
  updateModelId(modelId: number | null) { this.#modelId.next(modelId) }
  #artistId = new BehaviorSubject<number | null>(null)
  updateArtistId(artistId: number | null) { this.#artistId.next(artistId) }
  #styleId = new BehaviorSubject<number | null>(null)
  updateStyleId(styleId: number | null) { this.#styleId.next(styleId) }
  #franchiseId = new BehaviorSubject<number | null>(null)
  updateFranchiseId(franchiseId: number | null) { this.#franchiseId.next(franchiseId) }
  #mediaId = new BehaviorSubject<number | null>(null)
  updateMediaId(mediaId: number | null) { this.#mediaId.next(mediaId) }
  #linkId = new BehaviorSubject<number | null>(null)
  updateLinkId(linkId: number | null) { this.#linkId.next(linkId) }
  #linkCategoryId = new BehaviorSubject<number | null>(null)
  updateLinkCategoryId(linkCategoryId: number | null) { this.#linkCategoryId.next(linkCategoryId) }

  // Reload
  #refreshMoods = new Subject<void>()
  refreshMoods() { this.#refreshMoods.next() }
  
  // Get All
  moods$ = this.#refreshMoods.pipe(
    startWith(null),
    switchMap(() => this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetAll`)),
    map(response => response.moods)
  )
  tags$ = this.#http.get<GetAllTagsResponse>(`${this.#url}Tags/GetAll`).pipe(map(response => response.tags))
  tagCategories$ = this.#http.get<GetAllTagCategoriesResponse>(`${this.#url}TagCategories/GetAll`).pipe(map(response => response.tagCategories))
  artists$ = this.#http.get<GetAllArtistsResponse>(`${this.#url}Artists/GetAll`).pipe(map(response => response.artists))
  styles$ = this.#http.get<GetStylesResponse>(`${this.#url}Styles/GetAll`).pipe(map(response => response.styles))
  models$ = this.#http.get<GetAllModelsResponse>(`${this.#url}Models/GetAll`).pipe(map(response => response.models))
  franchises$ = this.#http.get<GetAllFranchisesResponse>(`${this.#url}Franchises/GetAll`).pipe(map(response => response.franchises))
  medias$ = this.#http.get<GetAllMediasResponse>(`${this.#url}Medias/GetAll`).pipe(map(response => response.medias))
  links$ = this.#http.get<GetLinksResponse>(`${this.#url}Links/GetAll`).pipe(map(response => response.links))
  linkCategories$ = this.#http.get<GetLinkCategoriesResponse>(`${this.#url}LinkCategories/GetAll`).pipe(map(response => response.linkCategories))

  // Get By ...
  mood$ = combineLatest([this.#moodId, this.#refreshMoods.pipe(startWith(null))])
  .pipe(
    switchMap(([moodId]) => {
      if (moodId === null) return of(undefined)
      return this.getMoodById(moodId)
    }),
    startWith(undefined)
  )
  tag$ = this.#tagId.pipe(switchMap(tagId => tagId ? this.getTagById(tagId) : of(undefined)), startWith(undefined))
  tagCategory$ = this.#tagCategoryId.pipe(switchMap(tagCategoryId => tagCategoryId ? this.getTagCategoryById(tagCategoryId) : of(undefined)), startWith(undefined))
  model$ = this.#modelId.pipe(switchMap(modelId => modelId ? this.getModelById(modelId) : of(undefined)), startWith(undefined))
  artist$ = this.#artistId.pipe(switchMap(artistId => artistId ? this.getArtistById(artistId) : of(undefined)), startWith(undefined))
  style$ = this.#styleId.pipe(switchMap(styleId => styleId ? this.getStyleById(styleId) : of(undefined)), startWith(undefined))
  franchise$ = this.#franchiseId.pipe(switchMap(franchiseId => franchiseId ? this.getFranchiseById(franchiseId) : of(undefined)), startWith(undefined))
  media$ = this.#mediaId.pipe(switchMap(mediaId => mediaId ? this.getMediaById(mediaId) : of(undefined)), startWith(undefined))
  link$ = this.#linkId.pipe(switchMap(linkId => linkId ? this.getLinkById(linkId) : of(undefined)), startWith(undefined))
  linkCategory$ = this.#linkCategoryId.pipe(switchMap(linkCategoryId => linkCategoryId ? this.getLinkCategoryById(linkCategoryId) : of(undefined)), startWith(undefined))
   
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

  tagsByCategory$ = this.#tagCategoryId.pipe(switchMap(tagCategoryId => tagCategoryId ? this.getTagsByCategory(tagCategoryId) : of([])), startWith([]))
  modelsByFranchise$ = this.#franchiseId.pipe(switchMap(franchiseId => franchiseId ? this.getModelsByFranchise(franchiseId) : of([])), startWith([]))
  artistsByStyle$ = this.#styleId.pipe(switchMap(styleId => styleId ? this.getArtistsByStyle(styleId) : of([])), startWith([]))
  franchisesByMedia$ = this.#mediaId.pipe(switchMap(mediaId => mediaId ? this.getFranchisesByMedia(mediaId) : of([])), startWith([]))
  linksByCategory$ = this.#linkCategoryId.pipe(switchMap(linkCategoryId => linkCategoryId ? this.getLinksByCategory(linkCategoryId) : of([])), startWith([]))
  
  getMoodById(moodId: number): Observable<MoodFull> {
    return this.#http.get<GetMoodByIdResponse>(`${this.#url}Moods/GetOneDetails/${moodId}`).pipe(map(response => response.mood))
  }  
  getTagById(tagId: number): Observable<TagFull> {
    return this.#http.get<GetTagByIdResponse>(`${this.#url}Tags/GetOneDetails/${tagId}`).pipe(map(response => response.tag))
  }  
  getTagCategoryById(tagCategoryId: number): Observable<TagCategoryFull> {
    return this.#http.get<GetTagCategoryByIdResponse>(`${this.#url}TagCategories/GetOneDetails/${tagCategoryId}`).pipe(map(response => response.tagCategory))
  }  
  getModelById(modelId: number): Observable<ModelFull> {
    return this.#http.get<GetModelResponse>(`${this.#url}Models/GetOneDetails/${modelId}`).pipe(map(response => response.model))
  }  
  getArtistById(artistId: number): Observable<ArtistFull> {
    return this.#http.get<GetArtistByIdResponse>(`${this.#url}Artists/GetOneDetails/${artistId}`).pipe(map(response => response.artist))
  }  
  getStyleById(styleId: number): Observable<StyleFull> {
    return this.#http.get<GetStyleResponse>(`${this.#url}Styles/GetOneDetails/${styleId}`).pipe(map(response => response.style))
  }  
  getFranchiseById(franchiseId: number): Observable<FranchiseFull> {
    return this.#http.get<GetFranchiseByIdResponse>(`${this.#url}Franchises/GetOneDetails/${franchiseId}`).pipe(map(response => response.franchise))
  }  
  getMediaById(mediaId: number): Observable<MediaFull> {
    return this.#http.get<GetMediaByIdResponse>(`${this.#url}Medias/GetOneDetails/${mediaId}`).pipe(map(response => response.media))
  }  
  getLinkById(linkId: number): Observable<LinkFull> {
    return this.#http.get<GetLinkResponse>(`${this.#url}Links/GetOneDetails/${linkId}`).pipe(map(response => response.link))
  }  
  getLinkCategoryById(linkCategoryId: number): Observable<LinkCategoryFull> {
    return this.#http.get<GetLinkCategoryResponse>(`${this.#url}LinkCategories/GetOneDetails/${linkCategoryId}`).pipe(map(response => response.linkCategory))
  }

  getMoodsByTag(tagId : number) : Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByTag/${tagId}`).pipe(map(response => response.moods))
  }
  getMoodsByModel(modelId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByModel/${modelId}`).pipe(map(response => response.moods))
  }
  getMoodsByArtist(artistId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByArtist/${artistId}`).pipe(map(response => response.moods))
  }
  getMoodsByFranchise(franchiseId: number): Observable<MoodLight[]> {
    return this.#http.get<GetMoodsResponse>(`${this.#url}Moods/GetByFranchise/${franchiseId}`).pipe(map(response => response.moods));
  }
  getTagsByCategory(tagCategoryId: number): Observable<TagLight[]> {
    return this.#http.get<GetTagsByCategoryResponse>(`${this.#url}Tags/GetByCategory/${tagCategoryId}`).pipe(map(response => response.tags));
  }
  getModelsByFranchise(franchiseId: number): Observable<ModelLight[]> {
    return this.#http.get<GetModelsResponse>(`${this.#url}Models/GetByFranchise/${franchiseId}`).pipe(map(response => response.models));
  }
  getArtistsByStyle(styleId: number): Observable<ArtistLight[]> {
    return this.#http.get<GetArtistsByStyleResponse>(`${this.#url}Artists/GetByStyle/${styleId}`).pipe(map(response => response.artists));
  }
  getFranchisesByMedia(mediaId: number): Observable<FranchiseLight[]> {
    return this.#http.get<GetFranchisesByMediaResponse>(`${this.#url}Franchises/GetByMedia/${mediaId}`).pipe(map(response => response.franchises));
  }
  getLinksByCategory(linkCategoryId: number): Observable<LinkLight[]> {
    return this.#http.get<GetLinksResponse>(`${this.#url}Links/GetByCategory/${linkCategoryId}`).pipe(map(response => response.links));
  }

  // Update.
  updateScore(form: UpdateMoodScoreCall): void {
    this.#http.put<UpdateMoodScoreResponse>(`${this.#url}Moods/UpdateScore`, form).pipe(
      take(1),
      tap(response => {
        if (response.success) {
          this.updateMoodId(form.businessId)
          this.refreshMoods()
        }
      }),
    ).subscribe()
  }

    // Update.
    public UpdateMood( form : MoodUpdateForm ) { 
      return this.#http.put<MoodUpdateResponse>(`${this.#url}Moods/Update`, form)
    }
  
    // Delete.
    public DeleteMood( moodId : number ) {
      return this.#http.delete<BaseResponse>(`${this.#url}Moods/Delete/${moodId}`)
    }
    public DeleteTag( tagId : number ) {
      return this.#http.delete<BaseResponse>(`${this.#url}Tags/Delete/${tagId}`)
    }

  // Observable.
  flow$ = combineLatest([
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
    this.link$,
    this.links$,
    this.linkCategory$,
    this.linksByCategory$,
    this.linkCategories$
  ]).pipe(
    map(([
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
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories
    ]) => ({
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
      link,
      links,
      linkCategory,
      linksByCategory,
      linkCategories
    }))
  )

  // Signal.
  flow = toSignal(this.flow$)
}