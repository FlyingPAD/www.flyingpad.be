import { Component, EventEmitter, HostListener, inject, Input, Output } from '@angular/core';
import { MediumFull } from '../../../interfaces/franchise';
import { FlowService } from '../../../services/flow.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MediumUpdateForm } from '../../../interfaces/forms-update';

@Component({
  selector: 'app-edit-medium',
  templateUrl: './edit-medium.component.html',
  styleUrl: './edit-medium.component.scss'
})
export class EditMediumComponent {
  @Input() medium: MediumFull | undefined = undefined
  @Output() trigger = new EventEmitter<void>()

  #flowService = inject(FlowService)
  #formBuilder = inject(FormBuilder)

  subscription = new Subscription()
  isDeleteDialogOpen: boolean = false

  editFormGroup!: FormGroup

  public ngOnInit(): void {
    this.editFormGroup = this.#formBuilder.group({
      name: [this.medium?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(30)]],
      description: [this.medium?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(100)]]
    })
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe()
  }

  public openDeleteDialog(): void {
    this.isDeleteDialogOpen = true
  }
  public closeDeleteDialog(): void {
    this.isDeleteDialogOpen = false
  }
  public closeDeleteDialogEmit(): void {
    this.isDeleteDialogOpen = false
    this.trigger.emit()
  }

  public onSubmit(): void {
    if (this.editFormGroup.valid && this.medium) {
      let form: MediumUpdateForm = {
        mediumId: this.medium.businessId,
        name: this.editFormGroup.value.name,
        description: this.editFormGroup.value.description
      }

      this.subscription = this.#flowService.UpdateMedium(form).subscribe((response) => {
        if (response.success) this.trigger.emit()
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