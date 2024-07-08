import { Component, HostListener, inject } from '@angular/core';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-media-gallery',
  templateUrl: './media-gallery.component.html',
  styleUrls: ['./media-gallery.component.scss']
})
export class MediaGalleryComponent 
{
  #flowService = inject(FlowService)

  flow = this.#flowService.flow

  updateFranchiseId(franchiseId: number): void {
    this.#flowService.updateFranchiseId(franchiseId)
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