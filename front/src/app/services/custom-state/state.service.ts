import { inject, Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { StorageService } from '../storage.service';
import { StorageProperties } from '../../enumerations/storage-properties';

@Injectable({
  providedIn: 'root'
})

export class StateService {
  #storageService = inject(StorageService)
  
  #moodId$ = new BehaviorSubject<number | undefined>(undefined)
  #tagId$ = new BehaviorSubject<number | undefined>(undefined)
  #tagCategoryId$ = new BehaviorSubject<number | undefined>(undefined)
  #artistId$ = new BehaviorSubject<number | undefined>(undefined)
  #modelId$ = new BehaviorSubject<number | undefined>(undefined)
  #franchiseId$ = new BehaviorSubject<number | undefined>(undefined)
  
  public get moodId$() { return this.#moodId$.asObservable() }
  public get tagId$() { return this.#tagId$.asObservable() }
  public get tagCategoryId$() { return this.#tagCategoryId$.asObservable() }
  public get artistId$() { return this.#artistId$.asObservable() }
  public get modelId$() { return this.#modelId$.asObservable() }
  public get franchiseId$() { return this.#franchiseId$.asObservable() }


  public setMoodId(moodId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateMoodId, moodId)
    this.#moodId$.next(moodId) 
  }
  public setTagId(tagId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateTagId, tagId)
    this.#tagId$.next(tagId) 
  }
  public setTagCategoryId(tagCategoryId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateTagCategoryId, tagCategoryId)
    this.#tagCategoryId$.next(tagCategoryId) 
  }
  public setArtistId(artistId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateArtistId, artistId)
    this.#artistId$.next(artistId) 
  }
  public setModelId(modelId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateModelId, modelId)
    this.#modelId$.next(modelId) 
  }
  public setFranchiseId(franchiseId: number | undefined): void { 
    this.#storageService.setItem(StorageProperties.StateFranchiseId, franchiseId)
    this.#franchiseId$.next(franchiseId) 
  }
}