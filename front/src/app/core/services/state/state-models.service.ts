import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { ModelDetails, ModelLight } from '../../models/model';

@Injectable({
  providedIn: 'root'
})
export class StateModelsService 
{
  // Properties :

  #totalModelsSubject = new BehaviorSubject<ModelLight[]>([])
  #currentmodelsSubject = new BehaviorSubject<ModelLight[]>([])
  #currentmodelsFSubject = new BehaviorSubject<ModelLight[]>([])
  #currentmodelsMSubject = new BehaviorSubject<ModelLight[]>([])
  #currentmodelSubject =  new BehaviorSubject<ModelDetails>(new ModelDetails())

  // Getters :
  
  get totalModels$()          { return this.#totalModelsSubject.asObservable() }
  get currentModels$()        { return this.#currentmodelsSubject.asObservable() }
  get currentModelsF$()       { return this.#currentmodelsFSubject.asObservable() }
  get currentModelsM$()       { return this.#currentmodelsMSubject.asObservable() }
  get currentModel$()         { return this.#currentmodelSubject.asObservable() }

  // Methods :

  updateTotalModels( models : ModelLight[] ) 
  {
    this.#totalModelsSubject.next( models )
  }

  updateCurrentModels( models : ModelLight[] ) 
  {
    this.#currentmodelsSubject.next( models )
  }

  updateCurrentModelsF( models : ModelLight[] ) 
  {
    this.#currentmodelsFSubject.next( models )
  }

  updateCurrentModelsM( models : ModelLight[] ) 
  {
    this.#currentmodelsMSubject.next( models )
  }

  updateCurrentModel( model : ModelDetails ) 
  {
    this.#currentmodelSubject.next( model )
  }
}