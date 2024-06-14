import { Injectable, inject } from '@angular/core';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, combineLatest, map, of, switchMap } from 'rxjs';
import { GetOneModelDetailsResponse, ModelDetails } from '../core/models/model';
import { toSignal } from '@angular/core/rxjs-interop';
import { GetMoodsByModelResponse } from '../core/models/mood';
import { GetFranchisesByModelResponse } from '../core/models/franchise';

@Injectable({
  providedIn: 'root'
})
export class ModelStateService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/'

  #selectedModelId = new BehaviorSubject<number | null>(null)
  selectedModelId$ = this.#selectedModelId.asObservable()
  updateSelectedModelId( modelId : number | null ) : void 
  { 
    this.#selectedModelId.next(modelId) 
  }

  model$ = this.selectedModelId$.pipe(
    switchMap(modelId => {
      if (modelId === null) 
        {
        return of(null)
      } 
      else 
      {
        return combineLatest([
          this.GetOneDetails(modelId),
          this.GetMoodsByModel(modelId),
          this.GetFranchisesByModel(modelId)
        ]).pipe(
          map(([model, moods, franchises]) => ({
            model: model,
            moods: moods,
            franchises: franchises
          }))
        )
      }
    })
  )
  model = toSignal(this.model$, { initialValue: { model : new ModelDetails(), moods : [], franchises : [] } })

  public GetOneDetails( modelId : number)
  {
    return this.#http.get<GetOneModelDetailsResponse>(this.#url + 'Models/GetOneDetails/' + modelId).pipe(
      map(response => response.model)
    )
  }

  public GetMoodsByModel( modelId : number )
  {
    return this.#http.get<GetMoodsByModelResponse>(this.#url + 'Moods/GetByModel/' + modelId).pipe(
      map(response => response.moods)
    )
  }

  public GetFranchisesByModel( modelId : number)
  {
    return this.#http.get<GetFranchisesByModelResponse>(this.#url + 'Franchises/GetByModel/' +  modelId).pipe(
      map(response => response.franchisesByModel)
    )
  }

  #currentmodelSubject =  new BehaviorSubject<ModelDetails>(new ModelDetails())
  get currentModel$()         { return this.#currentmodelSubject.asObservable() }
  updateCurrentModel( model : ModelDetails ) 
  {
    this.#currentmodelSubject.next( model )
  }
}