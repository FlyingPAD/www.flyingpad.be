import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject, map, combineLatest, switchMap, of, tap } from 'rxjs';
import { environment } from '../../environments/environment';
import { GetFranchiseResponse, GetFranchisesByMediaResponse, GetFranchisesResponse, GetMediaResponse, GetMediasResponse } from '../models/franchise';
import { BaseResponse } from '../models/base-response';
import { FranchiseCreateForm } from '../models/forms-create';
import { CreateFranchiseResponse } from '../models/responses-create';

@Injectable({
  providedIn: 'root'
})
export class FranchisesEditionService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedFranchiseId = new BehaviorSubject<number | null>(null)
  selectedFranchiseId$ = this.#selectedFranchiseId.asObservable()
  updateSelectedFranchise(franchiseId : number | null) {
    this.#selectedFranchiseId.next(franchiseId)
  }

  #selectedMediaId = new BehaviorSubject<number | null>(null)
  selectedMediaId$ = this.#selectedMediaId.asObservable()
  updateSelectedMedia(mediaId : number | null) {
    this.#selectedMediaId.next(mediaId)
  }

  medias$ = this.#http.get<GetMediasResponse>(this.#url + 'Medias/GetAll').pipe(
    map(x => x.medias)
  )

  franchises$ = this.#http.get<GetFranchisesResponse>(this.#url + 'Franchises/GetAll').pipe(
    map(x => x.franchises)
  )

  getFranchise( franchiseId : number )
  {
    return this.#http.get<GetFranchiseResponse>(this.#url + 'Franchises/GetOneDetails/' + franchiseId).pipe(
      map(response => response.franchise)
    )
  }

  getFranchisesByMedia( mediaId : number )
  {
    return this.#http.get<GetFranchisesByMediaResponse>(`${this.#url}Franchises/GetByMedia/${mediaId}`).pipe(
      map(response => response.franchises)
    )
  }

  getMediaDetails( mediaId : number )
  {
    return this.#http.get<GetMediaResponse>(`${this.#url}Medias/GetOneDetails/${mediaId}`).pipe(
      map(response => response.media)
    )
  }

  franchisesEditionFlow$ = combineLatest([
    this.selectedMediaId$,
    this.medias$,
    this.selectedFranchiseId$
  ]).pipe(
    switchMap(([selectedMediaId, medias, selectedFranchiseId]) => 
    {
      const franchises$ = selectedMediaId === null 
        ? this.franchises$
        : this.getFranchisesByMedia(selectedMediaId)

      const mediaDetails$ = selectedMediaId === null 
        ? of(null)
        : this.getMediaDetails(selectedMediaId)

      const franchise$ = selectedFranchiseId === null 
        ? of(null)
        : this.getFranchise(selectedFranchiseId)

      return combineLatest([franchises$, mediaDetails$, franchise$]).pipe(
        map(([franchises, mediaDetails, franchise]) => ({
          franchises,
          medias,
          mediaDetails,
          franchise
        }))
      )
    })
  )
  franchisesEditionFlow = toSignal(this.franchisesEditionFlow$, { initialValue: { franchises: [], medias: [], mediaDetails: null, franchise: null } })

  public CreateFranchise( form : FranchiseCreateForm )
  {
    return this.#http.post<CreateFranchiseResponse>(`${this.#url}Franchises/Create`, form).pipe(
      tap( () => this.updateSelectedMedia(null) )
    )
  }

  public UpdateFranchise( form : FranchiseCreateForm )
  {
    return this.#http.put<BaseResponse>(`${this.#url}Franchises/Update`, form)
  }

  public DeleteFranchise( franchiseId : number )
  {
    return this.#http.delete<BaseResponse>(`${this.#url}Franchises/Delete/` + franchiseId).pipe(
      tap( () => 
      {
        this.updateSelectedFranchise(null)
        this.updateSelectedMedia(null)
      })
    )
  }
}
