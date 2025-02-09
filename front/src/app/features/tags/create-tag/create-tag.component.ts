import { Component, EventEmitter, HostListener, inject, Input, Output } from '@angular/core';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { TagCreateForm } from '../../../interfaces/forms-create';
import { TagCategoryLight } from '../../../interfaces/tag-category';

@Component({
  selector: 'app-create-tag',
  templateUrl: './create-tag.component.html',
  styleUrl: './create-tag.component.scss'
})
export class CreateTagComponent {
  @Input() tagCategories!: TagCategoryLight[]
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)

  #subscription = new Subscription()

  public createFormGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    tagCategoryId: [0]
  })

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public onSubmit(): void {
    let form: TagCreateForm = {
      name: this.createFormGroup.value.name,
      description: this.createFormGroup.value.description,
      tagCategoryId: this.createFormGroup.value.tagCategoryId
    }

    if (this.createFormGroup.valid) {
      this.#subscription = this.#flowService.CreateTag(form).subscribe({
        next: () => {
          this.trigger.emit()
          this.#toastr.success('Tag was created.')
        },
        error: (error) => {
          this.#toastr.error(`Error : ${error}`)
        }
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