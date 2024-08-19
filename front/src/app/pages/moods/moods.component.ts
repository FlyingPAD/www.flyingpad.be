import { AfterViewChecked, Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';
import { MenuCustomService } from '../../services/menu-custom.service';
import { MenuDesktopService } from '../../services/menu-desktop.service';
import { UserService } from '../../services/user.service';
import { PaginationService } from '../../services/pagination.service';
import { ViewerService } from '../../services/viewer.service';

@Component({
  selector: 'app-moods',
  templateUrl: './moods.component.html',
  styleUrl: './moods.component.scss'
})
export class MoodsComponent implements OnInit, AfterViewChecked, OnDestroy {
  #flowService = inject(FlowService)
  userService = inject(UserService)
  menuService = inject(MenuDesktopService)
  menuCustom = inject(MenuCustomService)
  router = inject(Router)
  paginationService = inject(PaginationService)
  viewerService = inject(ViewerService)

  environment = environment.apiBaseUrl

  flow = this.#flowService.flow

  showGallery : boolean = true
  showDetails : boolean = false
  showEdition : boolean = false
  showDialog : boolean = false

  intervalId : any | undefined = undefined
  diaporamaSwitch : boolean = false

  topButtonIsActive = false             
  infoIsActive = false   
  leftCardIsActive : boolean = false

  getMoodHeight(focusState: boolean) {
    this.viewerService.getMoodHeight(focusState, window.innerHeight, this.flow()?.mood.height)
  }
  
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

  backToGallery(): void {
    this.showGallery = true
    this.showDetails = false
    this.showEdition = false
  }

  goEdition(): void {
    this.showGallery = false
    this.showDetails = false
    this.showEdition = true
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

  infoTrigger(): void {
    this.infoIsActive = !this.infoIsActive
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

  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
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
        this.infoTrigger()
        break
      case '+':
        this.menuTrigger()
        break
      case 'Backspace':
        this.backToGallery()
        break
    }
  }
}