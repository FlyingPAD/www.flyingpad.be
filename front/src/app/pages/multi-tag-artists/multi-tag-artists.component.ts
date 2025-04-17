import { Component, HostListener, inject, OnDestroy, OnInit } from '@angular/core'
import { FormBuilder, FormGroup } from '@angular/forms'
import { MultiTagService } from '../../services/multi-tag.service'
import { Router } from '@angular/router'
import { ArtistCheckBox } from '../../interfaces/artist'
import { RelationsMoodArtistForm } from '../../interfaces/relations'
import { NotificationService } from '../../services/user-interface/notification.service'
import { RelationsService } from '../../services/http/relations.service'
import { MoodsGalleryService } from '../../services/user-interface/moods-gallery.service'
import { GalleryType } from '../../enumerations/gallery-type'
import { ArtistService } from '../../services/http/artist.service'
import { Subject, takeUntil } from 'rxjs'

@Component({
  selector: 'app-multi-tag-artists',
  templateUrl: './multi-tag-artists.component.html'
})
export class MultiTagArtistsComponent implements OnInit, OnDestroy {
  #multiTagService = inject(MultiTagService)
  #artistService = inject(ArtistService)
  #relationService = inject(RelationsService)
  #moodsGalleryService = inject(MoodsGalleryService)
  #router = inject(Router)
  #formBuilder = inject(FormBuilder)
  #notificationService = inject(NotificationService)

  #destroy$ = new Subject<void>()

  public artistsFlow = this.#artistService.artistsFlow
  public selectedMoods = this.#multiTagService.selectedMoods

  public searchArtist = ''
  public form!: FormGroup


  ngOnInit(): void {
    const artistsData = this.mapArtists()

    const controlsConfig = artistsData.reduce((config, artist) => {
      config[artist.businessId.toString()] = [false]
      return config
    }, {} as { [key: string]: any })
    this.form = this.#formBuilder.group(controlsConfig)
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private mapArtists(): ArtistCheckBox[] {
    return (this.artistsFlow()?.artists ?? []).map(artist => ({ ...artist, isChecked: false }))
  }

  public filteredArtists(): ArtistCheckBox[] {
    return this.mapArtists().filter(artist => artist.name.toLowerCase().includes(this.searchArtist.toLowerCase()))
  }

  public onSubmit(): void {
    const artists = this.artistsFlow()?.artists ?? []
    const selectedArtistIds = artists.filter(artist => this.form.get(artist.businessId.toString())?.value)
      .map(artist => artist.businessId)

    if (selectedArtistIds.length === 0) {
      this.#notificationService.warning('No artists selected')
      return
    }
    const selectedMoodsList = this.selectedMoods() ?? []

    selectedMoodsList.forEach(mood => {
      const relationsForm: RelationsMoodArtistForm = { moodId: mood, artistIds: selectedArtistIds }
      this.#relationService.InsertRMA(relationsForm)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => {
          if (response.success) {
            this.form.reset()
            this.#multiTagService.resetSelection()
            this.#moodsGalleryService.setGalleryType(GalleryType.Gallery)
            this.#router.navigateByUrl('/central-gallery')
          }
        })
    })
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent): void {
    switch (event.key) {
      case 'Backspace':
        this.#router.navigateByUrl('/moods/multi-tag')
        break
    }    
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}