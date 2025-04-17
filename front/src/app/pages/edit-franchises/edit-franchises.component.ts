import { Component, inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FranchiseService } from '../../services/http/franchise.service';
import { StorageService } from '../../services/storage.service';
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service';
import { EditFranchisesViewMode } from '../../enumerations/view-modes-edition';
import { FranchiseLight } from '../../interfaces/franchise';
import { GalleryType } from '../../enumerations/gallery-type';
import { StateService } from '../../services/custom-state/state.service';
import { ActiveEntity, GalleryMode } from '../../enumerations/gallery-mode';

@Component({
  selector: 'app-edit-franchises',
  templateUrl: './edit-franchises.component.html'
})
export class EditFranchisesComponent implements OnInit {
  #stateService = inject(StateService)
  #franchiseService = inject(FranchiseService)
  #storageService = inject(StorageService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public franchisesFlow = this.#franchiseService.franchisesFlow

  public currentPage = 1
  public elementsPerPage: number = 12
  public searchFranchises: string = ''

  public viewModes = EditFranchisesViewMode
  public currentViewMode = EditFranchisesViewMode.ListView
  

  ngOnInit(): void {
    let storedPage = this.#storageService.getItem('pageFranchises')
    if (storedPage != null) this.setCurrentPage(storedPage as number)
  }

  public setCurrentPage(page: number): void {
    this.currentPage = page
    this.#storageService.setItem('pageFranchises', page)
  }

  public setViewMode(viewMode: EditFranchisesViewMode) {
    this.currentViewMode = viewMode
  }

  public filterFranchises(): FranchiseLight[] | undefined {
    return this.franchisesFlow()?.franchisesByMedium.filter(franchise => franchise.name.toLowerCase().includes(this.searchFranchises.toLowerCase()))
  }

  public go(): void {
    this.#stateService.setFranchiseId(this.franchisesFlow()?.franchise?.businessId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Franchise)
    this.#moodsGalleryService.setActiveEntity(ActiveEntity.Franchise)
    this.#router.navigateByUrl('/central-gallery')
  }

  public setFranchiseId(franchiseId: number | undefined): void {
    this.#stateService.setFranchiseId(franchiseId)
  }

  public setMediumId(mediumId: number | undefined): void {
    this.setCurrentPage(1)
    this.setViewMode(EditFranchisesViewMode.ListView)
    this.#franchiseService.setMediumId(mediumId)
  }
}