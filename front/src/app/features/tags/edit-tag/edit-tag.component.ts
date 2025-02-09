import { Component, EventEmitter, HostListener, inject, Input, OnInit, Output } from '@angular/core';
import { TagFull } from '../../../interfaces/tag';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { TagUpdateForm } from '../../../interfaces/forms-update';
import { FlowService } from '../../../services/flow.service';
import { TagCategoryLight } from '../../../interfaces/tag-category';

@Component({
  selector: 'app-edit-tag',
  templateUrl: './edit-tag.component.html',
  styleUrl: './edit-tag.component.scss'
})
export class EditTagComponent implements OnInit {
  @Input() tag: TagFull | undefined = undefined
  @Input() tagCategories: TagCategoryLight[] = []
  @Output() showListTrigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)
  #toastr = inject(ToastrService)

  #subscription = new Subscription()

  public isDeleteDialogOpen: boolean = false
  public editFormGroup!: FormGroup

  ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.tag?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.tag?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      tagCategoryId: [this.tag?.tagCategoryId, Validators.required]
    })
  }

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
    let form: TagUpdateForm = {
      tagId: this.tag ? this.tag.businessId : 0,
      name: this.editFormGroup.value.name,
      description: this.editFormGroup.value.description,
      tagCategoryId: this.editFormGroup.value.tagCategoryId
    }

    if (this.editFormGroup.valid) {
      this.#subscription = this.#flowService.UpdateTag(form).subscribe({
        next: () => {
          this.#toastr.success('Success !')
          this.showListTrigger.emit()
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