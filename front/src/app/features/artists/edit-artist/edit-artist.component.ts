import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { ArtistFull } from '../../../interfaces/artist';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FlowService } from '../../../services/http/flow.service';
import { StyleLight } from '../../../interfaces/style';
import { ArtistUpdateForm } from '../../../interfaces/forms-update';
import { ArtistService } from '../../../services/http/artist.service';

@Component({
  selector: 'app-edit-artist',
  templateUrl: './edit-artist.component.html',
  styleUrl: './edit-artist.component.scss'
})
export class EditArtistComponent implements OnInit {
  @Input() artist: ArtistFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #artistService = inject(ArtistService)
  #formBuilder = inject(FormBuilder)

  formGroup!: FormGroup
  isDeleteDialogOpen: boolean = false


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

  private populateCategories(styles: StyleLight[]): void {
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

      this.#artistService.updateArtist(form).subscribe((response) => { if (response.success) this.trigger.emit() })
    }
  }
}