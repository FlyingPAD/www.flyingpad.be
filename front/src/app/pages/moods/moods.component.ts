import { AfterViewChecked, Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';
import { PaginationService } from '../../services/display/pagination.service';
import { ViewerService } from '../../services/features/viewer.service';
import { MenuService } from '../../services/display/menu.service';
import { DisplayService } from '../../services/display/display.service';
import { MoodsService } from '../../services/moods.service';

@Component({
  selector: 'app-moods',
  templateUrl: './moods.component.html',
  styleUrl: './moods.component.scss'
})
export class MoodsComponent implements OnInit, AfterViewChecked, OnDestroy {
  #flowService = inject(FlowService)
  #menuService = inject(MenuService)
  #paginationService = inject(PaginationService)
  viewerService = inject(ViewerService)
  displayService = inject(DisplayService)
  moodsService = inject(MoodsService)

  private intervalId: any | undefined = undefined
  public flow = this.#flowService.flow
  public displayInfos = this.displayService.displayInfo
  public moodMenuState = this.moodsService.moodMenuState
  public environment = environment.apiBaseUrl
  public showDialog: boolean = false
  public leftCardIsActive: boolean = this.leftCardInit()

  ngOnInit(): void {
    this.getMoodHeight(false)
    window.scrollTo(0, 0)
    const businessIdString = `${this.flow()?.tag?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  ngAfterViewChecked(): void {
    const businessIdString = `${this.flow()?.tag?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  ngOnDestroy(): void {
    this.diaporamaStop()
  }

  private leftCardInit(): boolean {
    if (this.displayInfos().mode === 'Mobile') {
      return false
    } 
    else {
      return true
    }
  }

  public updateMoodMenuState(menuState: string): void {
    this.moodsService.updateMoodMenuState(menuState)
  }

  public diaporamaStart(isRandom: boolean): void {
    isRandom ? this.updateMoodId(null) : this.getPage('next')
    this.intervalId = setInterval(() => {
      isRandom ? this.updateMoodId(null) : this.getPage('next')
    },
      3000)
  }
  public diaporamaStop(): void {
    if (this.intervalId !== undefined) {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
  }

  public getPage(direction: string): void {
    const flow = this.flow()
    if (!flow) return

    if (direction === 'previous') {
      if (this.flow()?.moodsGalleryType === 'all') {
        this.updateMoodId(flow.moodsIndexes.previousMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'artist') {
        this.updateMoodId(flow.moodsByArtistIndexes.previousMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'model') {
        this.updateMoodId(flow.moodsByModelIndexes.previousMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'tag') {
        this.updateMoodId(flow.moodsByTagIndexes.previousMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'franchise') {
        this.updateMoodId(flow.moodsByFranchiseIndexes.previousMoodId)
      }
    }
    if (direction === 'next') {
      if (this.flow()?.moodsGalleryType === 'all') {
        this.updateMoodId(flow.moodsIndexes.nextMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'artist') {
        this.updateMoodId(flow.moodsByArtistIndexes.nextMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'model') {
        this.updateMoodId(flow.moodsByModelIndexes.nextMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'tag') {
        this.updateMoodId(flow.moodsByTagIndexes.nextMoodId)
      }
      if (this.flow()?.moodsGalleryType === 'franchise') {
        this.updateMoodId(flow.moodsByFranchiseIndexes.nextMoodId)
      }
    }
  }

  public getRandomMood(): void {
    this.#flowService.updateMoodId(null)
    this.updateMoodMenuState('details')
  }

  public updateMoodId(moodId: number | null): void {
    this.#flowService.updateMoodId(moodId)
    this.updateMoodMenuState('details')
  }
  public updateArtistId(artistId: number | null): void {
    this.#flowService.updateArtistId(artistId)
    this.updateMoodMenuState('gallery')
    this.#paginationService.resetArtistGalleryCurrentPage()
  }
  public updateModelId(modelId: number | null): void {
    this.#flowService.updateModelId(modelId)
    this.updateMoodMenuState('gallery')
    this.#paginationService.resetModelGalleryCurrentPage()
  }
  public updateTagId(tagId: number): void {
    this.#flowService.updateTagId(tagId)
    this.updateMoodMenuState('gallery')
    this.#paginationService.resetMoodsByTagCurrentPage()
  }
  public updateFranchiseId(franchiseId: number | null): void {
    this.#flowService.updateFranchiseId(franchiseId)
    this.updateMoodMenuState('gallery')
    this.#paginationService.resetFranchiseGalleryCurrentPage()
  }

  public scrollToStart(elementId: string): void {
    const domElement = document.getElementById(elementId)
    if (domElement) {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
    }
  }

  public toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  public menuTrigger(): void {
    this.#menuService.toggleRightMenu()
  }
  public leftCardToggle(): void {
    this.leftCardIsActive = !this.leftCardIsActive
  }

  public toggleDialog() {
    this.showDialog = !this.showDialog
  }

  public openMoodInNewTab(): void {
    let downloadLink = ''
    if (this.flow()?.mood.type === 1) {
      downloadLink = `${this.environment}/Content/img/${this.flow()?.mood.businessId}.${this.flow()?.mood.extension}`
    }
    else if (this.flow()?.mood.type === 2) {
      downloadLink = `${this.environment}/Content/video/${this.flow()?.mood.businessId}.${this.flow()?.mood.extension}`
    }
    if (downloadLink) {
      window.open(downloadLink, '_blank')
    }
  }

  public getMoodHeight(focusState: boolean) {
    this.viewerService.getMoodHeight(focusState, window.innerHeight, this.flow()?.mood.height)
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    if (this.moodMenuState() != 'edition') {
      switch (event.key) {
        case 'ArrowLeft':
          this.getPage('previous')
          break
        case 'ArrowRight':
          this.getPage('next')
          break
        case ' ':
          this.intervalId === undefined ? this.diaporamaStart(false) : this.diaporamaStop()
          break
        case 'Shift':
          this.openMoodInNewTab()
          break
        case '0':
          this.getRandomMood()
          break
        case 'Control':
          // this.toggleFocus()
          break
        case 'Enter':
          this.leftCardToggle()
          break
        case '+':
          this.menuTrigger()
          break
        case 'Backspace':
          this.updateMoodMenuState('gallery')
          break
      }
    }
  }
}