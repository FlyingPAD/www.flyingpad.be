import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCreateForm } from '../../../interfaces/forms-create';
import { LinkCategoryCheckBox } from '../../../interfaces/link';
import { LinkService } from '../../../services/http/link.service';

@Component({
  selector: 'app-create-link',
  templateUrl: './create-link.component.html',
  styleUrl: './create-link.component.scss'
})
export class CreateLinkComponent implements OnInit, OnDestroy {
  @Input() linkCategories: LinkCategoryCheckBox[] = []
  @Output() trigger = new EventEmitter<void>()

  #linkService = inject(LinkService)
  #builder = inject(FormBuilder)

  #subscription = new Subscription()

  public formGroup!: FormGroup

  get linkCategoriesArray(): FormArray {
    return this.formGroup.get('linkCategories') as FormArray
  }

  ngOnInit(): void {
    this.formGroup = this.#builder.group({
      name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      url: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(255)]],
      linkCategories: this.#builder.array(
        this.linkCategories.map(category => this.createCategoryFormGroup(category))
      )
    })
  }

  ngOnDestroy(): void {
    this.#subscription.unsubscribe();
  }

  private createCategoryFormGroup(category: LinkCategoryCheckBox): FormGroup {
    return this.#builder.group({
      businessId: [category.businessId],
      name: [category.name],
      isChecked: [false]
    })
  }

  public onSubmit(): void {
    if (this.formGroup.valid) {
      let categories = this.linkCategoriesArray?.value

      if (categories && Array.isArray(categories)) {
        let form: LinkCreateForm = {
          name: this.formGroup.value.name,
          description: this.formGroup.value.description,
          url: this.formGroup.value.url,
          linkCategoryIds: categories
            .filter((category: { isChecked: boolean }) => category.isChecked)
            .map((category: { businessId: number }) => category.businessId)
        }

        this.#subscription = this.#linkService.createLink(form).subscribe(response => { if (response.success) this.trigger.emit() })
      }
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.onSubmit()
        break
    }
  }
}