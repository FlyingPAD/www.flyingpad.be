import { Component, HostListener, inject } from '@angular/core'
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode'
import { Subject } from 'rxjs'
import { ModelService } from '../../services/http/model.service'
import { TagService } from '../../services/http/tag.service'
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service'
import { GalleryType } from '../../enumerations/gallery-type'
import { environment } from '../../../environments/environment'
import { ArtistService } from '../../services/http/artist.service'
import { FranchiseService } from '../../services/http/franchise.service'
import { MoodService } from '../../services/http/mood.service'
import { StateService } from '../../services/custom-state/state.service'
import { Router } from '@angular/router'

@Component({
  selector: 'app-central-gallery',
  templateUrl: './central-gallery.component.html',
  styleUrls: ['./central-gallery.component.scss']
})
export class CentralGalleryComponent {
  #stateService = inject(StateService)
  #moodService = inject(MoodService)
  #tagService = inject(TagService)
  #artistService = inject(ArtistService)
  #modelService = inject(ModelService)
  #franchiseService = inject(FranchiseService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public galleryModes = GalleryMode
  public galleryTypes = GalleryType
  public activeEntities = ActiveEntity

  public galleryMode = this.#moodsGalleryService.galleryMode
  public galleryType = this.#moodsGalleryService.galleryType
  public activeEntity = this.#moodsGalleryService.activeEntity

  public tagsFlow = this.#tagService.tagsFlow
  public artistsFlow = this.#artistService.artistsFlow
  public modelsFlow = this.#modelService.modelsFlow
  public franchisesFlow = this.#franchiseService.franchisesFlow

  public moodsFlow = this.#moodService.moodsFlow

  public moodInfoToggle = this.#moodsGalleryService.moodInfoToggle

  private intervalId: any | undefined = undefined
  public isDiaporamaActive: boolean = false
  public isShuffleActive: boolean = false

  public resetPaginationSignal$ = new Subject<void>()

  public environment = environment.apiBaseUrl

  public setModel(modelId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Model)
    this.resetPaginationSignal$.next()
    this.#stateService.setModelId(modelId)
  }

  public setFranchise(franchiseId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Franchise)
    this.resetPaginationSignal$.next()
    this.#stateService.setFranchiseId(franchiseId)
  }

  public setAndSwitchToMood(moodId: number): void {
    this.#moodsGalleryService.setGalleryType(GalleryType.Details)
    this.#stateService.setMoodId(moodId)
  }

  public setAndSwitchToModel(modelId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Model)
    this.resetPaginationSignal$.next()
    this.#stateService.setModelId(modelId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Model)
  }

  public setAndSwitchToFranchise(franchiseId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Franchise)
    this.resetPaginationSignal$.next()
    this.#stateService.setFranchiseId(franchiseId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Franchise)
  }

  public setAndSwitchToArtist(artistId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Default)
    this.resetPaginationSignal$.next()
    this.#stateService.setArtistId(artistId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Artist)
  }

  public setAndSwitchToTag(tagId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Default)
    this.resetPaginationSignal$.next()
    this.#stateService.setTagId(tagId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Tag)
  }

  public setAndSwitchToTagCategory(tagCategoryId: number): void {
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Default)
    this.resetPaginationSignal$.next()
    this.#stateService.setTagCategoryId(tagCategoryId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.TagCategory)
  }

  public openMoodInNewTab(): void {
    let downloadLink: string | undefined

    if (this.moodsFlow()?.mood?.type === 1) {
      downloadLink = `${this.environment}/Content/img/${this.moodsFlow()?.mood?.businessId}.${this.moodsFlow()?.mood?.extension}`
    }
    else if (this.moodsFlow()?.mood?.type === 2) {
      downloadLink = `${this.environment}/Content/video/${this.moodsFlow()?.mood?.businessId}.${this.moodsFlow()?.mood?.extension}`
    }
    if (downloadLink) window.open(downloadLink, '_blank')
  }

  public getCurrentMoodIndex(): number {
    let moodsArray = this.moodsFlow()?.moods ?? []

    if (moodsArray.length === 0 || !this.moodsFlow()?.mood) return -1
    return moodsArray.findIndex(m => m.businessId === this.moodsFlow()?.mood?.businessId)
  }

  public handleGetIndex(direction: string): void {
    let moodsArray = this.moodsFlow()?.moods ?? []
    let currentIndex = this.getCurrentMoodIndex()

    if (currentIndex === -1 || moodsArray.length === 0) return

    let newIndex: number

    if (direction === 'next') newIndex = (currentIndex + 1) % moodsArray.length
    else if (direction === 'previous') newIndex = (currentIndex - 1 + moodsArray.length) % moodsArray.length
    else return
    if (newIndex !== currentIndex) this.#stateService.setMoodId(moodsArray[newIndex].businessId)
  }

  public diaporamaStart(isRandom: boolean): void {
    this.isDiaporamaActive = true
    this.diaporamaBehavior(isRandom)
    this.intervalId = setInterval(() => {
      this.diaporamaBehavior(isRandom)
    },
      3000)
  }

  private diaporamaBehavior(isRandom: boolean): void {
    if (isRandom) {
      this.isShuffleActive = true
      this.#stateService.setMoodId(undefined)
      this.#moodsGalleryService.setGalleryMode(GalleryMode.Default)
    }
    else this.handleGetIndex('next')
  }

  public diaporamaStop(): void {
    if (this.intervalId !== undefined) {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
    this.isDiaporamaActive = false
    this.isShuffleActive = false
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'ArrowLeft':
        if (this.galleryType() === GalleryType.Details) this.handleGetIndex('previous')
        break
      case 'ArrowRight':
        if (this.galleryType() === GalleryType.Details) this.handleGetIndex('next')
        break
      case ' ':
        if (this.galleryType() === GalleryType.Details) {
          this.intervalId === undefined ? this.diaporamaStart(false) : this.diaporamaStop()
        }
        break
      case 'Shift':
        this.openMoodInNewTab()
        break
      case 'Backspace':
        if (this.galleryType() === GalleryType.Details) this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
        else this.#router.navigateByUrl('/dashboard')
        break
    }
  }
}