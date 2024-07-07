import { Component, EventEmitter, HostListener, inject, Input, Output } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { MenuDesktopService } from '../../../services/menu-desktop.service';
import { Location } from '@angular/common';
import { PaginationService } from '../../../services/pagination.service';
import { UserService } from '../../../services/user.service';
import { MenuCustomService } from '../../../services/menu-custom.service';
import { FlowService } from '../../../services/flow.service';
import { MoodLight } from '../../../models/mood';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent 
{
  #flowService = inject(FlowService)
  userService = inject(UserService)
  menuService = inject(MenuDesktopService)
  menuCustom = inject(MenuCustomService)
  router = inject(Router)
  location = inject(Location)
  paginationService = inject(PaginationService)

  @Input() moods : MoodLight[] | undefined = undefined
  @Output() moodId = new EventEmitter<number>()

  environment = environment.apiBaseUrl
  flow = this.#flowService.flow
  moodsPerPage :  number = 36      
  topButtonIsActive = false             
  infoIsActive = false          
  galleryType : string = 'all'

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
    this.galleryType = 'tags'
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

  handleMoodId(moodId : number) : void
  {
    this.moodId.emit(moodId)
  }
}