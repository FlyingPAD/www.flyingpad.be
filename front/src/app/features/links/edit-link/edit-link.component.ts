import { Component, EventEmitter, inject, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { FlowService } from '../../../services/flow.service';
import { LinkCategoryCheckBox, LinkFull } from '../../../models/link';
import { LinkUpdateForm } from '../../../models/forms-update';

@Component({
  selector: 'app-edit-link',
  templateUrl: './edit-link.component.html',
  styleUrls: ['./edit-link.component.scss']
})
export class EditLinkComponent implements OnInit {
  @Input() link: LinkFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  formGroup!: FormGroup
  isDeleteDialogOpen : boolean = false

  ngOnInit(): void {
    if (this.link) {
      this.formGroup = this.#formBuilder.group({
        name: [this.link.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.link.description, [Validators.required, Validators.maxLength(50)]],
        url: [this.link.url, [Validators.required, Validators.maxLength(100)]],
        linkCategories: this.#formBuilder.array([])
      })

      this.#flowService.getLinkCategoriesCheckBoxes(this.link.businessId)
        .subscribe(categories => this.populateCategories(categories))
    }
  }

  get linkCategoriesArray(): FormArray {
    return this.formGroup.get('linkCategories') as FormArray
  }

  populateCategories(categories: LinkCategoryCheckBox[]): void {
    categories.forEach(category => {
      this.linkCategoriesArray.push(
        this.#formBuilder.group({
          businessId: category.businessId,
          name: category.name,
          isChecked: category.isChecked || false
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
    if (this.formGroup.valid && this.link) {
      let selectedCategories = this.formGroup.value.linkCategories
        .filter((category: { isChecked: boolean }) => category.isChecked)
        .map((category: { businessId: number }) => category.businessId)

      let form: LinkUpdateForm = {
        linkId: this.link.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        url: this.formGroup.value.url,
        linkCategoryIds: selectedCategories
      }

      this.#flowService.UpdateLink(form).subscribe(response => { if(response.success) this.trigger.emit() })
    }
  }
}