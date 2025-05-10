import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { ArtistFull, StyleCheckBox } from '../../../interfaces/artist';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ArtistUpdateForm } from '../../../interfaces/http/forms-update';
import { ArtistService } from '../../../services/http/artist.service';
import { Subject, takeUntil } from 'rxjs';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-artist',
  templateUrl: './edit-artist.component.html'
})
export class EditArtistComponent implements OnInit, OnDestroy {
  #artistService = inject(ArtistService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() artist: ArtistFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  formGroup!: FormGroup


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

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateArtist(): void {
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
        .subscribe((response) => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateArtist()
        break
    }
  }
}