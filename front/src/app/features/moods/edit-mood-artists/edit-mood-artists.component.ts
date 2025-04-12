import { Component, Input, OnDestroy, OnInit, Output, EventEmitter, inject } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { ArtistCheckBox } from '../../../interfaces/artist';
import { MoodService } from '../../../services/http/mood.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-edit-mood-artists',
  templateUrl: './edit-mood-artists.component.html',
  styleUrls: ['./edit-mood-artists.component.scss']
})
export class EditMoodArtistsComponent implements OnInit, OnDestroy {
  #moodService = inject(MoodService)

  @Input() mood!: MoodFull
  @Output() artistsSelected = new EventEmitter<number[]>()

  #destroy$ = new Subject<void>()

  public artists: ArtistCheckBox[] = []
  public input: string = ''
  

  ngOnInit(): void {
    this.#moodService.getArtistsCheckBoxesByMood(this.mood.businessId).pipe(
      takeUntil(this.#destroy$))
      .subscribe(data => {
        this.artists = data
        this.emitSelectedArtists()
      })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
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