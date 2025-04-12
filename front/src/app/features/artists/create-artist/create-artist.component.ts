import { Component, EventEmitter, Input, OnDestroy, OnInit, Output, inject } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { ArtistCreateForm } from '../../../interfaces/forms-create';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleLight } from '../../../interfaces/artist';

@Component({
  selector: 'app-create-artist',
  templateUrl: './create-artist.component.html',
  styleUrls: ['./create-artist.component.scss']
})
export class CreateArtistComponent implements OnInit, OnDestroy {
  @Input() styles: StyleLight[] = []
  @Output() setViewMode = new EventEmitter<void>()

  #artistService = inject(ArtistService)
  #builder = inject(FormBuilder)

  #subscription = new Subscription()
  form!: FormGroup

  get stylesArray(): FormArray {
    return this.form.get('styles') as FormArray
  }

  ngOnInit(): void {
    this.form = this.#builder.group({
      name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      styles: this.#builder.array(
        this.styles.map(style => this.createStyleForm(style))
      )
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe();
  }

  private createStyleForm(style: StyleLight): FormGroup {
    return this.#builder.group({
      businessId: [style.businessId],
      name: [style.name],
      isChecked: [false]
    })
  }

  onSubmit(): void {
    if (this.form.valid) {
      let styles = this.stylesArray?.value

      if (styles && Array.isArray(styles)) {
        let form: ArtistCreateForm = {
          name: this.form.value.name,
          description: this.form.value.description,
          styleIds: styles
            .filter((style: { isChecked: boolean }) => style.isChecked)
            .map((style: { businessId: number }) => style.businessId)
        }

        this.#subscription = this.#artistService.createArtist(form).subscribe((response) => {if(response.success) this.setViewMode.emit()})
      }
    }
  }
}