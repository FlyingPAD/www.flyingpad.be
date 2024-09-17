import { Component, EventEmitter, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { LinkCategoryCheckBox } from '../../../models/link';
import { FlowService } from '../../../services/flow.service';
import { FormArray, FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { LinkCreateForm } from '../../../models/forms-create';

@Component({
  selector: 'app-create-link',
  templateUrl: './create-link.component.html',
  styleUrl: './create-link.component.scss'
})
export class CreateLinkComponent implements OnInit, OnDestroy {
  @Input() linkCategories!: LinkCategoryCheckBox[]
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #builder = inject(FormBuilder)
  #router = inject(Router)
  #toastr = inject(ToastrService)

  subscription = new Subscription()
  formGroup!: FormGroup

  get linkCategoriesArray(): FormArray {
    return this.formGroup.get('linkCategories') as FormArray
  }

  linkCategoryControl(index: number): FormGroup {
    return this.linkCategoriesArray.at(index) as FormGroup
  }

  ngOnInit(): void {
    this.formGroup = this.#builder.group({
      name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      url: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      linkCategories: this.#builder.array(this.linkCategories.map(linkCategory => this.createLinkCategoryGroup(linkCategory)))
    })
  }

  private createLinkCategoryGroup(linkCategory: LinkCategoryCheckBox): FormGroup {
    return this.#builder.group({
      businessId: [linkCategory.businessId],
      name: [linkCategory.name],
      isChecked: [linkCategory.isChecked]
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

  onSubmit(): void {
    if (this.formGroup.valid) {
      const form: LinkCreateForm = {
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        url: this.formGroup.value.url,
        linkCategories: this.formGroup.value.linkCategories
          .filter((category: { isChecked: boolean }) => category.isChecked)
          .map((category: {businessId : number}) => category.businessId)
      };

      this.subscription = this.#flowService.CreateLink(form).subscribe({
        next: (response) => {
          if (response.success) this.trigger.emit()
        }
      })
    } else {
      this.#toastr.error('Form is invalid. Please check the fields.')
    }
  }
}