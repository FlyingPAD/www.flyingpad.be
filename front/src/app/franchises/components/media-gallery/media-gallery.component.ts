import { Component, inject } from '@angular/core';
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
}