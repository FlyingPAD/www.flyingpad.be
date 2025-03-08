import { Component, inject } from '@angular/core';
import { FlowService } from '../../services/http/flow.service';
import { Router } from '@angular/router';
import { PaginationService } from '../../services/pagination.service';
import { ArtistLight } from '../../interfaces/artist';
import { MoodsService } from '../../services/moods.service';

@Component({
  selector: 'app-edit-artists',
  templateUrl: './edit-artists.component.html'
})
export class EditArtistsComponent {
  #flowService = inject(FlowService)
  #router = inject(Router)
  #paginationService = inject(PaginationService)
  #moodsService = inject(MoodsService)

  public flow = this.#flowService.flow
  public currentPage = this.#paginationService.editArtistsCurrentPage
  public searchArtists: string = ''
  public elementsPerPage: number = 12
  public showList: boolean = true
  public showNew: boolean = false
  public showNewCategory: boolean = false
  public showEdit: boolean = false
  public showEditCategory: boolean = false

  private triggerReset(): void {
    this.showList = false
    this.showNew = false
    this.showNewCategory = false
    this.showEdit = false
    this.showEditCategory = false
  }
  public triggerShowList(): void {
    this.triggerReset()
    this.showList = true
  }
  public triggerShowNew(): void {
    this.triggerReset()
    this.showNew = true
  }
  public triggerShowNewCategory(): void {
    this.triggerReset()
    this.showNewCategory = true
  }
  public triggerShowEdit(): void {
    this.triggerReset()
    this.showEdit = true
  }
  public triggerShowEditCategory(): void {
    this.triggerReset()
    this.showEditCategory = true
  }

  public updateCurrentPage(page: number): void {
    this.#paginationService.updateEditArtistsCurrentPage(page)
  }

  public filterArtists(): ArtistLight[] | undefined {
    return this.flow()?.artistsByStyle.filter(artist => artist.name.toLowerCase().includes(this.searchArtists.toLowerCase()))
  }

  public go(): void {
    this.#moodsService.updateMoodMenuState('gallery')
    this.#router.navigateByUrl('/moods')
  }

  public setArtist(artist: ArtistLight): void {
    this.#flowService.updateArtistId(artist.businessId)
    this.#paginationService.resetArtistGalleryCurrentPage()
  }

  public updateStyleId(styleId: number | null): void {
    this.#paginationService.resetEditArtistsCurrentPage()
    this.#flowService.updateStyleId(styleId)
  }
}