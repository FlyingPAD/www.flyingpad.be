import { Component, HostListener, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-medium-gallery',
  templateUrl: './medium-gallery.component.html',
  styleUrl: './medium-gallery.component.scss'
})
export class MediumGalleryComponent {
  #flowService = inject(FlowService)

  topButtonIsActive = false

  flow = this.#flowService.flow

  updateFranchiseId(franchiseId: number): void {
    this.#flowService.updateFranchiseId(franchiseId)
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }
  toTop(): void {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }
}