import { Component, HostListener, inject } from '@angular/core';
import { FranchiseStateService } from '../../../core/services/franchise.service';

@Component({
  selector: 'app-media-gallery',
  templateUrl: './media-gallery.component.html',
  styleUrls: ['./media-gallery.component.scss']
})
export class MediaGalleryComponent 
{
  #franchisesService = inject(FranchiseStateService)

  singleMediaFlow = this.#franchisesService.singleMediaFlow

  updateFranchiseId( franchiseId : number | null)
  {
    this.#franchisesService.updateSelectedFranchiseId(franchiseId)
  }

  // TO TOP BUTTON
  topButtonIsActive = false    
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
}