import { Component, Input, OnDestroy, OnInit, inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { StyleLight } from '../../../models/style';
import { FlowService } from '../../../services/flow.service';

@Component({
  selector: 'app-create-artist',
  templateUrl: './create-artist.component.html',
  styleUrls: ['./create-artist.component.scss']
})
export class CreateArtistComponent implements OnInit, OnDestroy {
  @Input() styles! : StyleLight[]
  #flowService = inject(FlowService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  subscription = new Subscription()
  formGroup! : FormGroup

  get getStyles() {
    return this.formGroup.get('styles') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#builder.group({
      name: ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ["", [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      styles: this.#builder.array(this.styles.map(style => this.#builder.group({
        businessId: [style.businessId],
        name: [style.name],
        isChecked: [style.isChecked]
      })))
    })
  }

  ngOnDestroy() : void {
    this.subscription.unsubscribe()
  }

  onSubmit() : void {
    if (this.formGroup.valid) {
      this.subscription = this.#flowService.CreateArtist(this.formGroup.value).subscribe({
        next : () => {
          this.#toastr.success('Artist was successfully created.')
          this.#router.navigateByUrl('/artists/edition')
        },
        error : () => {
          this.#toastr.error('Error ...')
        }
      })
    }
  }
}