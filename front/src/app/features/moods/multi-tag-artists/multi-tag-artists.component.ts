import { Component, OnDestroy, inject } from '@angular/core';
import { MultiTagService } from '../../../services/features/multi-tag.service';
import { toSignal } from '@angular/core/rxjs-interop';
import { RelationsMoodArtistForm } from '../../../interfaces/relations';
import { Router } from '@angular/router';
import { FlowService } from '../../../services/flow.service';
import { ArtistCheckBox } from '../../../interfaces/artist';

@Component({
  selector: 'app-multi-tag-artists',
  templateUrl: './multi-tag-artists.component.html',
  styleUrl: './multi-tag-artists.component.scss'
})
export class MultiTagArtistsComponent implements OnDestroy {
  #flowService = inject(FlowService)
  multiTagService = inject(MultiTagService)
  router = inject(Router)

  artists$ = this.multiTagService.getArtists()
  artists = toSignal(this.artists$)

  searchArtist : string = ''

  ngOnDestroy(): void {
    this.multiTagService.reset()
  }

  onSubmit() {
    let form : RelationsMoodArtistForm = { moodId : 0, artistIds : [] }
    let idListArtist : number[] = []

    this.artists()?.forEach(artist => {
      if (artist.isChecked)
      {
        idListArtist.push(artist.businessId)
      }
    })
    form.artistIds = idListArtist

    this.multiTagService.selectedMoods.forEach(mood => {
      form.moodId = mood      
      this.#flowService.InsertRMA(form).subscribe()
    })

    this.router.navigateByUrl('/moods')
  }

  filterArtists(): ArtistCheckBox[] | undefined {
    return this.artists()?.filter(m => m.name.toLowerCase().includes(this.searchArtist.toLowerCase()))
  }
}