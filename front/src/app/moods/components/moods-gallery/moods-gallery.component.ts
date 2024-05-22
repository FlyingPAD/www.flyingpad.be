import { Component, HostListener, inject } from '@angular/core';
import { MoodStateService } from '../../../core/services/mood.service';
import { Router } from '@angular/router';
import { environment } from '../../../../environments/environment';
import { TagStateService } from '../../../core/services/tag-state.service';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';
import { Location } from '@angular/common';

@Component({
  selector: 'app-moods-gallery',
  templateUrl: './moods-gallery.component.html',
  styleUrl: './moods-gallery.component.scss'
})
export class MoodsGalleryComponent 
{
  // Properties :

  menuService = inject(MenuDesktopService)
  moodsService = inject(MoodStateService)
  tagsService = inject(TagStateService)
  router = inject(Router)
  location = inject(Location)                 // Navigation

  environment = environment.apiBaseUrl        // Environment
  moods = this.moodsService.moodsFlow         // Signal
  tagsList = this.tagsService.tagsList        // Signal
  moodsPerPage :  number = 36                 // Pagination : Items per Page
  currentPage :   number = 1                  // Pagination : Current Page
  topButtonIsActive = false                   // To Top Button Trigger
  infoIsActive = false                        // Info Box Trigger

  // Methods :

  //TODO: Make a directive for scrolling & refactor scroll logic
  
  ngOnInit() : void
  {
    window.scrollTo(0, 0)
    const businessIdString = `${this.moods().tagDetails?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  ngAfterViewChecked() : void
  {
    const businessIdString = `${this.moods().tagDetails?.businessId ?? 'fallbackValue'}`
    this.scrollToStart(businessIdString)
  }

  pageReset()
  {
    this.currentPage = 1
  }

  getRandomMood() : void
  {
    this.moodsService.updateSelectedMoodId(null)
    this.moodsService.updateSelectedGalleryType('')
    this.router.navigateByUrl('/moods/mood-details')
  }

  updateMoodId( moodId : number | null ) : void
  {
    this.moodsService.updateSelectedMoodId(moodId)
    this.router.navigateByUrl('moods/mood-details')
  }

  updateTagId( tagId : number | null ) : void
  {
    this.moodsService.updateSelectedGalleryType('tag')
    this.moodsService.updateSelectedTagId( tagId )
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
      case 'Control':
        this.infoTrigger()
        break
      case '.':
        this.menuTrigger()
        break
      case 'Backspace':
        this.location.back()
        break
    }
  }
}