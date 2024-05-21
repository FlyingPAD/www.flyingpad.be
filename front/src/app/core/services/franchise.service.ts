import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { GetMediasFullListResponse, GetOneMediaDetailsResponse, MediaDetails } from '../models/media';
import { BehaviorSubject, Observable, combineLatest, map, of, switchMap } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import { FranchiseDetails, FranchiseLight, GetAllFranchisesResponse, GetFranchisesByMediaResponse, GetOneFranchiseDetailsResponse } from '../models/franchise';
import { GetModelsByFranchiseResponse, ModelLight } from '../models/model';
import { GetMoodsByFranchiseResponse, MoodLight } from '../models/mood';

@Injectable({
  providedIn: 'root'
})
export class FranchiseStateService 
{
    #http = inject(HttpClient) 
    #url : string = environment.apiBaseUrl + '/api/V1/'

    // Single Franchise Page :

    #selectedFranchiseId = new BehaviorSubject<number | null>(null)
    selectedFranchiseId$ = this.#selectedFranchiseId.asObservable()
    updateSelectedFranchiseId(franchiseId : number | null){ this.#selectedFranchiseId.next(franchiseId)}

    franchise$ = this.selectedFranchiseId$.pipe(
      switchMap(franchiseId => {
        if (franchiseId === null) 
          {
          return of(null)
        } 
        else 
        {
          return combineLatest([
            this.GetOneFranchiseDetails(franchiseId),
            this.GetModelsByFranchise(franchiseId),
            this.GetMoodsByFranchise(franchiseId)
          ]).pipe(
            map(([franchise, models, moods]) => ({
              franchise: franchise,
              models: models,
              modelsM : models.filter(model => model.gender === 'M'),
              modelsF : models.filter(model => model.gender === 'F'),
              moods : moods,
              totalMoods : moods.length
            }))
          )
        }
      })
    )
    franchise = toSignal(this.franchise$, { initialValue : 
      { 
        franchise : new FranchiseDetails(), 
        models : [], 
        modelsM : [],
        modelsF : [],
        moods : [], 
        totalMoods : 0 
      } })

    public GetOneFranchiseDetails( franchiseId : number) : Observable<FranchiseDetails>
    {
      return this.#http.get<GetOneFranchiseDetailsResponse>(this.#url + 'Franchises/GetOneDetails/' +  franchiseId).pipe(
        map(response => response.franchise)
      )
    }

    public GetModelsByFranchise( franchiseId : number ) : Observable<ModelLight[]>
    {
      return this.#http.get<GetModelsByFranchiseResponse>(this.#url + 'Models/GetByFranchise/' + franchiseId).pipe(
        map(response => response.modelsByFranchise)
      )
    }

    public GetMoodsByFranchise( franchiseId : number ) : Observable<MoodLight[]>
    {
      return this.#http.get<GetMoodsByFranchiseResponse>(this.#url + 'Moods/GetByFranchise/' + franchiseId).pipe(
        map(response => response.moods)
      )
    }

    // Single Media Page

    #selectedMediaId = new BehaviorSubject<number | null>(null)
    selectedMediaId$ = this.#selectedMediaId.asObservable()
    updateSelectedMediaId(mediaId : number | null){ this.#selectedMediaId.next(mediaId)}

    singleMediaFlow$ = this.selectedMediaId$.pipe(
      switchMap(mediaId => {
        if(mediaId === null)
          {
            return of(null)
          }
        else
        {
          return combineLatest([
            this.GetOneMediaDetails(mediaId),
            this.GetFranchisesByMedia(mediaId)
          ]).pipe(
            map(([media, franchises]) => ({
              media : media,
              franchises : franchises
            }))
          )
        }
      })
    )
    singleMediaFlow = toSignal(this.singleMediaFlow$, { initialValue : { media : new MediaDetails(), franchises : [] } })

    public GetOneMediaDetails( mediaId : number) : Observable<MediaDetails>
    {
      return this.#http.get<GetOneMediaDetailsResponse>(this.#url + 'Medias/GetOneDetails/' +  mediaId).pipe(
        map(response => response.media)
      )
    }

    public GetFranchisesByMedia( mediaId : number) : Observable<FranchiseLight[]>
    {
      return this.#http.get<GetFranchisesByMediaResponse>(this.#url + 'Franchises/GetByMedia/' +  mediaId).pipe(
        map(response => response.franchises)
      )
    }

    // Medias + Franchises + Models Page :

    medias$ = this.#http.get<GetMediasFullListResponse>(this.#url + 'Franchises/GetFranchisesList').pipe(
      map(response => response.medias)
    )
    medias = toSignal( this.medias$, { initialValue : [] } )

    franchises$ = this.#http.get<GetAllFranchisesResponse>(this.#url + 'Franchises/GetAll').pipe(
      map(response => response.franchises)
    )
    franchises = toSignal(this.franchises$, { initialValue: [] })

}