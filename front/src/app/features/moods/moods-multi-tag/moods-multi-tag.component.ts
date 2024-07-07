import { Component, HostListener, inject } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { Location } from '@angular/common';
import { MultiTagService } from '../../../services/multi-tag.service';
import { PaginationService } from '../../../services/pagination.service';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-moods-multi-tag',
  templateUrl: './moods-multi-tag.component.html',
  styleUrl: './moods-multi-tag.component.scss'
})
export class MoodsMultiTagComponent 
{
  #flowService = inject(FlowService)
  menuService = inject(MenuDesktopService)
  router = inject(Router)
  location = inject(Location)                 // Navigation
  multiTagService = inject(MultiTagService)
  paginationService = inject(PaginationService)

  environment = environment.apiBaseUrl        // Environment

  flow = this.#flowService.flow
  moodsPerPage :  number = 36                 // Pagination : Items per Page
  topButtonIsActive = false                   // To Top Button Trigger
  infoIsActive = false                        // Info Box Trigger
  selectedMoods: number[] = []

  selectionToggle(moodId : number) : void
  {
    this.multiTagService.selectionToggle(moodId)
  }
  checkIfSelected(moodId : number) : boolean
  {
    return this.multiTagService.checkIfSelected(moodId)
  }

  // Methods :

  //TODO: Make a directive for scrolling & refactor scroll logic
  
  ngOnInit() : void
  {
    window.scrollTo(0, 0)
    const businessIdString = `${this.flow()?.tag?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  ngAfterViewChecked() : void
  {
    const businessIdString = `${this.flow()?.tag?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  pageReset()
  {
    this.paginationService.moodsByTagCurrentPageReset()
  }

  getRandomMood() : void
  {
    this.#flowService.updateMoodId(null)
    // this.moodsService.updateSelectedGalleryType('')
    this.router.navigateByUrl('/moods/mood-details')
  }

  updateMoodId( moodId : number | null ) : void
  {
    this.#flowService.updateMoodId(moodId)
    this.router.navigateByUrl('moods/mood-details')
  }

  updateTagId( tagId : number | null ) : void
  {
    // this.moodsService.updateSelectedGalleryType('tag')
    this.#flowService.updateTagId( tagId )
  }

  scrollToStart( elementId : string ) : void 
  {
    const domElement = document.getElementById( elementId )

    if (domElement) 
    {
      domElement.scrollIntoView({ behavior: "smooth", block: "center", inline: "nearest" });
    }
  }

  infoTrigger()
  {
    this.infoIsActive = !this.infoIsActive
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }

  toTop() : void 
  {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }

  menuTrigger()
  {
    this.menuService.menuRTrigger()
  }

  // KEYBOARD CONFIGURATION
  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
      case 'Enter':
        this.infoTrigger()
        break
      case '+':
        this.menuTrigger()
        break
      case 'Backspace':
        this.location.back()
        break
    }
  }
}