import { Component, inject } from '@angular/core';
import { LinksService } from '../../../core/services/links.service';
import { MoodStateService } from '../../../core/services/mood.service';
import { MenuDesktopService } from '../../../core/services/menu-desktop.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.scss']
})
export class GalleryComponent 
{
  #moodsService = inject(MoodStateService)
  linksState = inject(LinksService)
  menuService = inject(MenuDesktopService)

  itemsPerPage : number = 20                        // Pagination
  currentPage : number = 1                          // Pagination
  combinedState = this.linksState.combinedState     // Signal

  updateCategory( categoryId : number) : void
  {
    this.linksState.updateSelectedCategory(categoryId)
    this.resetPage()
  }
  resetCategory() : void
  {
    this.linksState.updateSelectedCategory(null)
    this.resetPage()
  }

  resetPage() : void
  {
    this.currentPage = 1
  }

  getRandomMood() : void
  {
    this.#moodsService.updateSelectedGalleryType('')
    this.#moodsService.updateSelectedMoodId(null)
  }

  menuTrigger()
  {
    this.menuService.menuRActive = !this.menuService.menuRActive
  }
}