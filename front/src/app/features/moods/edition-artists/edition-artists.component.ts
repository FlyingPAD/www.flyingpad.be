import { Component, inject, Input, OnDestroy, OnInit } from '@angular/core';
import { MoodFull } from '../../../models/mood';
import { ArtistCheckBox } from '../../../models/artist';
import { FlowService } from '../../../services/flow.service';
import { Subscription } from 'rxjs';
import { RelationsMoodArtistForm } from '../../../models/relations';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-edition-artists',
  templateUrl: './edition-artists.component.html',
  styleUrl: './edition-artists.component.scss'
})
export class EditionArtistsComponent implements OnInit, OnDestroy {
  #flowService = inject(FlowService)
  #toastr = inject(ToastrService)
  @Input() mood! : MoodFull

  input : string = ''

  subscription = new Subscription()
  subscriptionRelations = new Subscription()
  artists! : ArtistCheckBox[]

  ngOnInit(): void {
    this.subscription = this.#flowService.getArtistsCheckBoxByMood(this.mood.businessId).subscribe({
      next : data => {
        this.artists = data
      }
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
    this.subscriptionRelations.unsubscribe()
  }
  filterArtists() {
    return this.artists.filter(artist => artist.name.toLowerCase().includes(this.input.toLowerCase()))
  }

  onSubmit() {  
    let rmaForm : RelationsMoodArtistForm = {
      moodId : this.mood.businessId, 
      artistIds : this.artists.filter(artist => artist.isChecked).map(artist => artist.businessId)
    }    
  
    if (rmaForm.artistIds.length === 0) {
      this.#toastr.error('No artists selected. Please select at least one artist.')
      return
    }
  
    this.subscriptionRelations = this.#flowService.InsertRMA(rmaForm).subscribe({
      next: () => {
        this.#toastr.success('Update Successfull !')
      },
      error: (error) => {
        this.#toastr.error('Failed to update artists. Please try again.')
        console.error('Error updating artists:', error)
      }
    })
  }
}