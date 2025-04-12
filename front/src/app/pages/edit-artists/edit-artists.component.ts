import { Component, inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ArtistLight } from '../../interfaces/artist';
import { ArtistService } from '../../services/http/artist.service';
import { StorageService } from '../../services/storage.service';
import { MoodsGalleryService } from '../../services/moods-gallery.service';
import { EditArtistsViewMode } from '../../enumerations/view-modes-edition';
import { GalleryType } from '../../enumerations/gallery-type';
import { StateService } from '../../services/custom-state/state.service';
import { GalleryMode } from '../../enumerations/gallery-mode';

@Component({
  selector: 'app-edit-artists',
  templateUrl: './edit-artists.component.html'
})
export class EditArtistsComponent implements OnInit {
  #stateService = inject(StateService)
  #artistService = inject(ArtistService)
  #storageService = inject(StorageService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)

  public artistsFlow = this.#artistService.artistsFlow

  public currentPage = 1
  public elementsPerPage: number = 12
  public searchArtists: string = ''

  public viewModes = EditArtistsViewMode
  public currentViewMode = EditArtistsViewMode.ListView
  

  ngOnInit(): void {
    let storedPage = this.#storageService.getItem('pageArtists')
    if (storedPage != null) this.setCurrentPage(storedPage as number)
  }

  public setCurrentPage(page: number): void {
    this.currentPage = page
    this.#storageService.setItem('pageArtists', page)
  }

  public setViewMode(viewMode: EditArtistsViewMode) {
    this.currentViewMode = viewMode
  }

  public filterArtists(): ArtistLight[] | undefined {
    return this.artistsFlow()?.artistsByStyle.filter(artist => artist.name.toLowerCase().includes(this.searchArtists.toLowerCase()))
  }

  public go(): void {
    this.#stateService.setArtistId(this.artistsFlow()?.artist?.businessId)
    this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
    this.#moodsGalleryService.setGalleryMode(GalleryMode.Artist)
    this.#router.navigateByUrl('/central-gallery')
  }

  public setArtistId(artistId: number | undefined): void {
    this.#stateService.setArtistId(artistId)
  }

  public setStyleId(styleId: number | undefined): void {
    this.setCurrentPage(1)
    this.setViewMode(EditArtistsViewMode.ListView)
    this.#artistService.setStyleId(styleId)
  }
}