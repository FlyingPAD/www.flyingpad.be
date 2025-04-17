import { Component, EventEmitter, HostListener, Input, OnDestroy, OnInit, Output, inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { ArtistCreateForm } from '../../../interfaces/forms-create';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleLight } from '../../../interfaces/artist';

@Component({
  selector: 'app-create-artist',
  templateUrl: './create-artist.component.html'
})
export class CreateArtistComponent implements OnInit, OnDestroy {
  @Input() styles: StyleLight[] = []
  @Output() setViewMode = new EventEmitter<void>()

  #artistService = inject(ArtistService)
  #builder = inject(FormBuilder)

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup

  get stylesArray(): FormArray {
    return this.formGroup.get('styles') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#builder.group({
      name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      styles: this.#builder.array(
        this.styles.map(style => this.createStyleForm(style))
      )
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private createStyleForm(style: StyleLight): FormGroup {
    return this.#builder.group({
      businessId: [style.businessId],
      name: [style.name],
      isChecked: [false]
    })
  }

  public createArtist(): void {
    if (this.formGroup.valid) {
      let styles = this.stylesArray?.value

      if (styles && Array.isArray(styles)) {
        let form: ArtistCreateForm = {
          name: this.formGroup.value.name,
          description: this.formGroup.value.description,
          styleIds: styles
            .filter((style: { isChecked: boolean }) => style.isChecked)
            .map((style: { businessId: number }) => style.businessId)
        }

        this.#artistService.createArtist(form)
          .pipe(takeUntil(this.#destroy$))
          .subscribe((response) => { if (response.success) this.setViewMode.emit() })
      }
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createArtist()
        break
    }
  }
}