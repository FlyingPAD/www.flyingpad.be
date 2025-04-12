import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { StyleUpdateForm } from '../../../interfaces/forms-update';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleFull } from '../../../interfaces/artist';

@Component({
  selector: 'app-edit-style',
  templateUrl: './edit-style.component.html',
  styleUrl: './edit-style.component.scss'
})
export class EditStyleComponent implements OnInit, OnDestroy {
  @Input() style: StyleFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #artistService = inject(ArtistService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()

  public isDeleteDialogOpen: boolean = false
  public formGroup!: FormGroup

  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      name: [this.style?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.style?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }

  public closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  
  public closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.trigger.emit()
  }

  public onSubmit(): void {
    if (this.formGroup.valid && this.style) {
      let form: StyleUpdateForm = {
        styleId: this.style.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      }

      if (this.formGroup.valid) {
        this.#subscription = this.#artistService.updateStyle(form).subscribe((response) => { if (response.success) this.trigger.emit() })
      }
    }
  }
}