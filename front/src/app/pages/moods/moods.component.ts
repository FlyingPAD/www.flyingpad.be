import { AfterViewChecked, Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';
import { MenuDesktopService } from '../../services/display/menu-desktop.service';
import { PaginationService } from '../../services/display/pagination.service';
import { ViewerService } from '../../services/display/viewer.service';

@Component({
  selector: 'app-moods',
  templateUrl: './moods.component.html',
  styleUrl: './moods.component.scss'
})
export class MoodsComponent implements OnInit, AfterViewChecked, OnDestroy {
  #flowService = inject(FlowService)
  menuService = inject(MenuDesktopService)
  paginationService = inject(PaginationService)
  viewerService = inject(ViewerService)

  environment = environment.apiBaseUrl

  flow = this.#flowService.flow

  showGallery : boolean = true
  showDetails : boolean = false
  showEdition : boolean = false
  showMultiTag : boolean = false
  showDialog : boolean = false

  intervalId : any | undefined = undefined
           
  leftCardIsActive : boolean = false
  
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

  showOff(): void {
    this.showGallery = false
    this.showDetails = false
    this.showEdition = false
    this.showMultiTag = false
  }

  showGalleryON(): void {
    this.showOff()
    this.showGallery = true
  }

  showDetailsON(): void {
    this.showOff()
    this.showDetails = true
  }

  showEditionON(): void {
    this.showOff()
    this.showEdition = true
  }

  showMultiTagON(): void {
    this.showOff()
    this.showMultiTag = true
  }

  pageReset(): void {
    this.paginationService.moodsByTagCurrentPageReset()
  }

  diaporamaStart(isRandom: boolean): void {
    isRandom ? this.updateMoodId(null) : this.getPage('next')
    this.intervalId = setInterval(() => 
    {
      isRandom ? this.updateMoodId(null) : this.getPage('next')
    }, 
    3000)
  }  
  diaporamaStop(): void {
    if (this.intervalId !== undefined) {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
  }

  getPage(direction: string): void {
    const flow = this.flow()
    if(!flow) return

    if(direction === 'previous') {
      if(this.flow()?.moodsGalleryType === 'all') {
        this.updateMoodId(flow.moodsIndexes.previousMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'artist') {
        this.updateMoodId(flow.moodsByArtistIndexes.previousMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'model') {
        this.updateMoodId(flow.moodsByModelIndexes.previousMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'tag') {
        this.updateMoodId(flow.moodsByTagIndexes.previousMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'franchise') {
        this.updateMoodId(flow.moodsByFranchiseIndexes.previousMoodId)
      }
    }
    if(direction === 'next') {
      if(this.flow()?.moodsGalleryType === 'all') {
        this.updateMoodId(flow.moodsIndexes.nextMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'artist') {
        this.updateMoodId(flow.moodsByArtistIndexes.nextMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'model') {
        this.updateMoodId(flow.moodsByModelIndexes.nextMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'tag') {
        this.updateMoodId(flow.moodsByTagIndexes.nextMoodId)
      }
      if(this.flow()?.moodsGalleryType === 'franchise') {
        this.updateMoodId(flow.moodsByFranchiseIndexes.nextMoodId)
      }
    }
  }

  getRandomMood(): void {
    this.#flowService.updateMoodId(null)
    this.showGallery = false
    this.showDetails = true
    this.showEdition = false
  }

  updateMoodId(moodId: number | null): void {
    this.#flowService.updateMoodId(moodId)
    this.showGallery = false
    this.showDetails = true
    this.showEdition = false
  }
  updateArtistId(artistId: number | null): void {
    this.#flowService.updateArtistId(artistId)
    this.showGallery = true
    this.showDetails = false
    this.showEdition = false
    this.pageReset()
  }
  updateModelId(modelId: number | null): void {
    this.#flowService.updateModelId(modelId)
    this.showGallery = true
    this.showDetails = false
    this.showEdition = false
    this.pageReset()
  }
  updateTagId(tagId: number): void {
    this.#flowService.updateTagId(tagId)
    this.showGallery = true
    this.showDetails = false
    this.showEdition = false
    this.pageReset()
  }
  updateFranchiseId(franchiseId: number | null): void {
    this.#flowService.updateFranchiseId(franchiseId)
    this.showGallery = true
    this.showDetails = false
    this.showEdition = false
    this.pageReset()
  }

  scrollToStart( elementId : string ): void {
    const domElement = document.getElementById( elementId )
    if (domElement) {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
    }
  }

  toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  menuTrigger(): void {
    this.menuService.menuRTrigger()
  }
  leftCardToggle(): void {
    this.leftCardIsActive = !this.leftCardIsActive
  }

  handleDialog() {
    this.showDialog = false
  }
  openDialog() {
    this.showDialog = !this.showDialog
  }

  openMoodInNewTab() : void {
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

  getMoodHeight(focusState: boolean) {
    this.viewerService.getMoodHeight(focusState, window.innerHeight, this.flow()?.mood.height)
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    if(this.showEdition != true) {
      switch (event.key) {
        case 'ArrowLeft':
          this.getPage('previous')
          break
        case 'ArrowRight':
          this.getPage('next')
          break
        case ' ':
          // this.intervalId === undefined ? this.diaporamaStart(false) : this.diaporamaStop()
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
          this.showGalleryON()
          break
      }
    }
  }
}