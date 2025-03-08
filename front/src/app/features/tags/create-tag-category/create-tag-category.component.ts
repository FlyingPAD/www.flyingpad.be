import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { TagCategoryCreateForm } from '../../../interfaces/forms-create';
import { TagCategoryService } from '../../../services/http/tag-category.service';

@Component({
  selector: 'app-create-tag-category',
  templateUrl: './create-tag-category.component.html',
  styleUrl: './create-tag-category.component.scss'
})
export class CreateTagCategoryComponent implements OnDestroy {
  @Output() trigger = new EventEmitter<void>()

  #tagCategoryService = inject(TagCategoryService)
  #formBuilder = inject(FormBuilder)

  createFormGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public onSubmit(): void {
    let form: TagCategoryCreateForm = {
      name: this.createFormGroup.value.name,
      description: this.createFormGroup.value.description,
    }

    if (this.createFormGroup.valid) {
      this.#subscription = this.#tagCategoryService.createTagCategory(form).subscribe(response => { if (response.success) this.trigger.emit() })
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