import { Component, inject, Input } from '@angular/core';
import { ArtistFull } from '../../../interfaces/artist';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { ArtistUpdateForm } from '../../../interfaces/forms-update';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-artist-details-flow',
  templateUrl: './artist-details-flow.component.html',
  styleUrl: './artist-details-flow.component.scss'
})
export class ArtistDetailsFlowComponent {
  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)
  @Input() artist! : ArtistFull | undefined
  triggerDelete : boolean = false

  formGroup : FormGroup = this.#formBuilder.group
  ({
    name : [this.artist?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
  })

  update(): void {
    if (this.artist && this.formGroup.valid) 
    {  
      let form : ArtistUpdateForm = 
      {
       artistId : this.artist?.businessId,
       name : this.formGroup.value.name,
       description : this.formGroup.value.description,
       styleIds : []
      }
      this.#flowService.UpdateArtist(form).subscribe({
        next: () => {
          this.#toastr.success('Artist successfully updated.')
        },
        error: (error) => {
          this.#toastr.error('Error : ' + error);
        }
      })
    }
    this.formGroup.reset()
  }

  triggerDeleteDialog(): void {
    this.triggerDelete = !this.triggerDelete
  }

  delete(): void { 
    if(this.artist)
      {
        this.#flowService.DeleteArtist(this.artist?.businessId).subscribe({
          next: () => {
            this.#toastr.success('Artist successfully deleted.')
          },
          error: (error) => {
            this.#toastr.error('Error : ' + error);
          }
        })
      }
  }
}