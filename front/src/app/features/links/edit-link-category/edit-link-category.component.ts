import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, Output } from '@angular/core';
import { LinkCategoryFull } from '../../../interfaces/link';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { LinkCategoryUpdateForm } from '../../../interfaces/forms-update';
import { LinkCategoryService } from '../../../services/http/link-category.service';

@Component({
  selector: 'app-edit-link-category',
  templateUrl: './edit-link-category.component.html',
  styleUrl: './edit-link-category.component.scss'
})
export class EditLinkCategoryComponent implements OnDestroy {
  @Input() linkCategory: LinkCategoryFull | undefined = undefined
  @Output() showListTrigger = new EventEmitter<void>()

  #linkCategoryService = inject(LinkCategoryService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()

  public isDeleteDialogOpen: boolean = false
  public formGroup: FormGroup = this.#formBuilder.group({
    name: [this.linkCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: [this.linkCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })


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
    this.showListTrigger.emit()
  }

  public onSubmit(): void {
    let form: LinkCategoryUpdateForm = {
      linkCategoryId: this.linkCategory ? this.linkCategory.businessId : 0,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description
    }

    if (this.formGroup.valid) {
      this.#subscription = this.#linkCategoryService.updateLinkCategory(form).subscribe((response) => {
        if (response.success) this.showListTrigger.emit()
      })
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