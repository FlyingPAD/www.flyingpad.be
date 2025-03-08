import { Component, HostListener, inject, OnInit } from '@angular/core'
import { FormBuilder, FormGroup } from '@angular/forms'
import { MultiTagService } from '../../../services/multi-tag.service'
import { FlowService } from '../../../services/http/flow.service'
import { MoodsService } from '../../../services/moods.service'
import { Router } from '@angular/router'
import { ArtistCheckBox } from '../../../interfaces/artist'
import { RelationsMoodArtistForm } from '../../../interfaces/relations'
import { NotificationService } from '../../../services/notification.service'

@Component({
  selector: 'app-multi-tag-artists',
  templateUrl: './multi-tag-artists.component.html',
  styleUrl: './multi-tag-artists.component.scss'
})
export class MultiTagArtistsComponent implements OnInit {
  #flowService = inject(FlowService)
  #multiTagService = inject(MultiTagService)
  #moodsService = inject(MoodsService)
  #router = inject(Router)
  #formBuilder = inject(FormBuilder)
  #notificationService = inject(NotificationService)

  public selectedMoods = this.#multiTagService.selectedMoods
  public artists = this.#multiTagService.artists
  public searchArtist: string = ''
  public form!: FormGroup

  ngOnInit(): void {
    const controlsConfig = this.artists().reduce((config, artist) => {
      config[artist.businessId.toString()] = [false]
      return config
    }, {} as { [key: string]: any })
    this.form = this.#formBuilder.group(controlsConfig)
  }

  get filteredArtists(): ArtistCheckBox[] {
    return this.artists()?.filter(artist =>
      artist.name.toLowerCase().includes(this.searchArtist.toLowerCase())
    )
  }

  public onSubmit(): void {
    const selectedArtistIds: number[] = this.artists()
      .filter(artist => this.form.get(artist.businessId.toString())?.value)
      .map(artist => artist.businessId)

    if (selectedArtistIds.length === 0) {
      this.#notificationService.warning('No artists selected')
    }
    else {
      const relationsForm: RelationsMoodArtistForm = {
        moodId: 0,
        artistIds: selectedArtistIds
      }

      this.selectedMoods().forEach(mood => {
        relationsForm.moodId = mood
        this.#flowService.InsertRMA(relationsForm).subscribe()
      })

      this.form.reset()
      this.#multiTagService.resetSelection()
      this.#moodsService.updateMoodMenuState('gallery')
      this.#router.navigateByUrl('moods')
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}