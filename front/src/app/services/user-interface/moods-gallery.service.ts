import { inject, Injectable, signal, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode';
import { GalleryType } from '../../enumerations/gallery-type';
import { EditMoodViewMode } from '../../enumerations/view-modes-edition';
import { StorageService } from '../storage.service';
import { StorageProperties } from '../../enumerations/storage-properties';

@Injectable({
  providedIn: 'root'
})
export class MoodsGalleryService {
  #storageService = inject(StorageService)
 
  #galleryMode$ = new BehaviorSubject<GalleryMode>(GalleryMode.Default)
  #galleryType$ = new BehaviorSubject<GalleryType>(GalleryType.Gallery)
  #editMoodViewMode$ = new BehaviorSubject<EditMoodViewMode>(EditMoodViewMode.InfoView)
  #activeEntity$ = new BehaviorSubject<ActiveEntity>(ActiveEntity.Default)

  public get galleryMode$() { return this.#galleryMode$.asObservable() }
  public get activeEntity$() { return this.#activeEntity$.asObservable() }

  public galleryMode = toSignal(this.#galleryMode$) as Signal<GalleryMode>
  public galleryType = toSignal(this.#galleryType$) as Signal<GalleryType>
  public activeEntity = toSignal(this.#activeEntity$) as Signal<ActiveEntity>
  public editMoodViewMode = toSignal(this.#editMoodViewMode$) as Signal<EditMoodViewMode>
  

  public moodSizeToggle = signal<boolean>(false)
  public moodInfoToggle = signal<boolean>(false)


  constructor() {
    let storedActiveEntity = this.#storageService.getItem(StorageProperties.ActiveEntity)
    let storedGalleryMode = this.#storageService.getItem(StorageProperties.GalleryMode)
    let storedGalleryType = this.#storageService.getItem(StorageProperties.GalleryType)

    if (storedActiveEntity != null) { this.setActiveEntity(storedActiveEntity as ActiveEntity) }
    if (storedGalleryMode != null) { this.setGalleryMode(storedGalleryMode as GalleryMode) }
    if (storedGalleryType != null) { this.setGalleryType(storedGalleryType as GalleryType) }
  }

  public setGalleryMode(galleryMode: GalleryMode): void {
    this.#storageService.setItem(StorageProperties.GalleryMode, galleryMode)
    this.#galleryMode$.next(galleryMode)
  }  

  public setGalleryType(galleryType: GalleryType): void {
    this.#storageService.setItem(StorageProperties.GalleryType, galleryType)
    this.#galleryType$.next(galleryType)
  }

  public setActiveEntity(activeEntity: ActiveEntity): void {
    this.#storageService.setItem(StorageProperties.ActiveEntity, activeEntity)
    this.#activeEntity$.next(activeEntity)
  }

  public setEditMoodViewMode(viewMode: EditMoodViewMode): void {
    this.#editMoodViewMode$.next(viewMode)
  }

  public toggleMoodSize(): void { this.moodSizeToggle.update(current => !current) }
  public toggleMoodInfo(): void { this.moodInfoToggle.update(current => !current) }
}