import { Component, inject } from '@angular/core';
import { LinksStateService } from '../../../core/services/links-state.service';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent 
{
  linksState = inject(LinksStateService)

  itemsPerPage : number = 20   // Pagination
  currentPage : number = 1     // Pagination

  links = this.linksState.links
}
