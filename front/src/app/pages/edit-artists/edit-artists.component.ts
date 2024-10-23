import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/flow.service';
import { Router } from '@angular/router';
import { PaginationService } from '../../services/display/pagination.service';
import { ArtistLight } from '../../interfaces/artist';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-edit-artists',
  templateUrl: './edit-artists.component.html',
  styleUrl: './edit-artists.component.scss'
})
export class EditArtistsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  paginationService = inject(PaginationService)
  #imageURLService = inject(ImageUrlService)

  flow = this.#flowService.flow

  searchArtists : string = ''
  elementsPerPage : number = 12

  showList : boolean = true
  showNew : boolean = false
  showNewCategory : boolean = false
  showEdit : boolean = false
  showEditCategory : boolean = false

  triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showNewCategory = false
    this.showEdit = false
    this.showEditCategory = false
  }
  triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }
  triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  filterArtists(): ArtistLight[] | undefined {
    return this.flow()?.artistsByStyle.filter(artist => artist.name.toLowerCase().includes(this.searchArtists.toLowerCase()))
  }

  go():void {
    this.#router.navigateByUrl('/moods')
  }

  setArtist(artist : ArtistLight): void {
    this.#flowService.updateArtistId(artist.businessId)
  }

  updateStyleId(styleId : number | null): void {
    this.paginationService.editModelsCurrentPageReset()
    this.#flowService.updateStyleId(styleId)
  }

  public getImageUrl(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}