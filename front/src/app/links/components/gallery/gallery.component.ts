import { Component, inject } from '@angular/core';
import { LinksService } from '../../../core/services/links.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrls: ['./gallery.component.scss']
})
export class GalleryComponent 
{
  linksState = inject(LinksService)

  itemsPerPage : number = 20   // Pagination
  currentPage : number = 1     // Pagination

  combinedState = this.linksState.combinedState

  updateCategory( categoryId : number)
  {
    this.linksState.updateSelectedCategory(categoryId)
    this.resetPage()
  }
  resetCategory()
  {
    this.linksState.updateSelectedCategory(null)
    this.resetPage()
  }

  resetPage()
  {
    this.currentPage = 1
  }
}