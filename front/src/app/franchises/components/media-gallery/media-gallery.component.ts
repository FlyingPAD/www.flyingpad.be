import { Component, inject } from '@angular/core';
import { FranchiseStateService } from '../../../core/services/franchise-state.service';

@Component({
  selector: 'app-media-gallery',
  templateUrl: './media-gallery.component.html',
  styleUrls: ['./media-gallery.component.scss']
})
export class MediaGalleryComponent 
{
  #franchisesService = inject(FranchiseStateService)

  singleMediaFlow = this.#franchisesService.singleMediaFlow

ngOnInit()
{
  console.log('Flow:', this.singleMediaFlow);
}
}