import { Component, HostListener, inject } from '@angular/core';
import { LinksEditionService } from '../../../services/links-edition.service';
import { MenuDesktopService } from '../../../services/menu-desktop.service';

@Component({
  selector: 'app-links-gallery',
  templateUrl: './links-gallery.component.html',
  styleUrl: './links-gallery.component.scss'
})
export class LinksGalleryComponent 
{
  #linksEditionService = inject(LinksEditionService)
  menuService = inject(MenuDesktopService)            

  // Signal
  linksEditionFlow = this.#linksEditionService.linksEditionFlow

  // Pagination
  elementsPerPage : number = 18
  currentPage : number = 1
  resetPage() : void
  {
    this.currentPage = 1
  }

  // Filter Links Search Input
  searchLinks : string = ''
  filterLinks() 
  {
    return this.linksEditionFlow().links.filter(m => m.name.toLowerCase().includes(this.searchLinks.toLowerCase()))
  }

  // Trigger Right column
  menuTrigger() : void
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }

  // Category Selection
  updateCategory( categoryId : number | null ) : void
  {
    this.resetPage()
    this.#linksEditionService.updateSelectedCategory( categoryId )
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