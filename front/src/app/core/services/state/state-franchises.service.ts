import { Injectable } from '@angular/core';
import { FranchiseDetails, FranchiseLight } from '../../models/franchise';
import { BehaviorSubject } from 'rxjs';
import { MediaDetails, MediaLight } from '../../models/media';

@Injectable({
  providedIn: 'root'
})
export class StateFranchisesService 
{
  // Properties :

  #totalFranchisesSubject = new BehaviorSubject<FranchiseLight[]>([])
  #currentfranchisesSubject = new BehaviorSubject<FranchiseLight[]>([])
  #currentfranchiseSubject =  new BehaviorSubject<FranchiseDetails>(new FranchiseDetails())

  #totalMediasSubject = new BehaviorSubject<MediaLight[]>([])
  #currentMediaSubject = new BehaviorSubject<MediaDetails>(new MediaDetails())

  // Getters :
  
  get totalFranchises$()   { return this.#totalFranchisesSubject.asObservable() }
  get currentFranchises$() { return this.#currentfranchisesSubject.asObservable() }
  get currentFranchise$()  { return this.#currentfranchiseSubject.asObservable() }

  get totalMedias$()       { return this.#totalMediasSubject.asObservable() }
  get currentMedia$()      { return this.#currentMediaSubject.asObservable() }

  // Methods :

  updateTotalFranchises( franchises : FranchiseLight[] ) 
  {
    this.#totalFranchisesSubject.next( franchises )
  }

  updateCurrentFranchises( franchises : FranchiseLight[] ) 
  {
    this.#currentfranchisesSubject.next( franchises )
  }
}