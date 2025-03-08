import { Component, Input, OnDestroy, OnInit, Output, EventEmitter, inject } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { ArtistCheckBox } from '../../../interfaces/artist';
import { Subscription } from 'rxjs';
import { FlowService } from '../../../services/http/flow.service';

@Component({
  selector: 'app-edit-mood-artists',
  templateUrl: './edit-mood-artists.component.html',
  styleUrls: ['./edit-mood-artists.component.scss']
})
export class EditMoodArtistsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)

  @Input() mood!: MoodFull
  @Output() artistsSelected = new EventEmitter<number[]>()

  #subscription = new Subscription()

  public artists: ArtistCheckBox[] = []
  public input: string = ''

  ngOnInit(): void {
    this.#subscription = this.#flowService.getArtistsCheckBoxByMood(this.mood.businessId).subscribe({
      next: (data) => {
        this.artists = data
        this.emitSelectedArtists()
      }
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  private emitSelectedArtists() {
    const selectedIds = this.artists
      .filter((a) => a.isChecked)
      .map((a) => a.businessId)
    this.artistsSelected.emit(selectedIds)
  }

  public filterArtists() {
    return this.artists.filter((artist) =>
      artist.name.toLowerCase().includes(this.input.toLowerCase())
    )
  }

  public onArtistCheckChange(artist: ArtistCheckBox) {
    artist.isChecked = !artist.isChecked
    this.emitSelectedArtists()
  }
}