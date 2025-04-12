import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { ArtistFull, StyleCheckBox } from '../../../interfaces/artist';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ArtistUpdateForm } from '../../../interfaces/forms-update';
import { ArtistService } from '../../../services/http/artist.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-edit-artist',
  templateUrl: './edit-artist.component.html',
  styleUrl: './edit-artist.component.scss'
})
export class EditArtistComponent implements OnInit, OnDestroy {
  @Input() artist: ArtistFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #artistService = inject(ArtistService)
  #formBuilder = inject(FormBuilder)

  #destroy$ = new Subject<void>()

  formGroup!: FormGroup
  isDeleteDialogOpen: boolean = false


  ngOnInit(): void {
    if (this.artist) {
      this.formGroup = this.#formBuilder.group({
        name: [this.artist.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.artist.description, [Validators.required, Validators.maxLength(50)]],
        styles: this.#formBuilder.array([])
      })

      this.#artistService.getStylesCheckBoxesByArtist(this.artist.businessId)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(styles => this.populateCategories(styles))
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  get stylesArray(): FormArray {
    return this.formGroup.get('styles') as FormArray
  }

  private populateCategories(styles: StyleCheckBox[]): void {
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

      this.#artistService.updateArtist(form)
      .pipe(takeUntil(this.#destroy$))
      .subscribe((response) => { if (response.success) this.trigger.emit() })
    }
  }
}