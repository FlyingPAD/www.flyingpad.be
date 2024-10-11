import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { ArtistFull } from '../../../models/artist';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FlowService } from '../../../services/flow.service';
import { StyleLight } from '../../../models/style';
import { ArtistUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-edit-artist',
  templateUrl: './edit-artist.component.html',
  styleUrl: './edit-artist.component.scss'
})
export class EditArtistComponent implements OnInit {
  @Input() artist: ArtistFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup!: FormGroup
  isDeleteDialogOpen : boolean = false


  ngOnInit(): void {
    if (this.artist) {
      this.formGroup = this.#formBuilder.group({
        name: [this.artist.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.artist.description, [Validators.required, Validators.maxLength(50)]],
        styles: this.#formBuilder.array([])
      })

      this.#flowService.getStylesCheckBoxesByArtist(this.artist.businessId)
        .subscribe(styles => this.populateCategories(styles))
    }
  }

  get stylesArray(): FormArray {
    return this.formGroup.get('styles') as FormArray
  }

  populateCategories(styles: StyleLight[]): void {
    styles.forEach(style => {
      this.stylesArray.push(
        this.#formBuilder.group({
          businessId: style.businessId,
          name: style.name,
          isChecked: style.isChecked || false
        })
      )
    })
  }

  openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.trigger.emit()
  }

  onSubmit(): void {
    if (this.formGroup.valid && this.artist) {
      let selectedStyles = this.formGroup.value.styles
        .filter((style: { isChecked: boolean }) => style.isChecked)
        .map((style: { businessId: number }) => style.businessId)

      let form: ArtistUpdateForm = {
        artistId: this.artist.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        styleIds: selectedStyles
      }

      this.#flowService.UpdateArtist(form).subscribe((response) => { if(response.success) this.trigger.emit() })
    }
  }
}