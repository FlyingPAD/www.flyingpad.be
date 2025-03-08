import { Component, EventEmitter, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { StyleCreateForm } from '../../../interfaces/forms-create';
import { StyleService } from '../../../services/http/style.service';

@Component({
  selector: 'app-create-style',
  templateUrl: './create-style.component.html',
  styleUrl: './create-style.component.scss'
})
export class CreateStyleComponent implements OnDestroy {
  @Output() trigger = new EventEmitter<void>()

  #styleService = inject(StyleService)
  #formBuilder = inject(FormBuilder)

  formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  #subscription = new Subscription()

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  onSubmit(): void {
    let form: StyleCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#subscription = this.#styleService.createStyle(form).subscribe((response) => {
        if (response.success) this.trigger.emit()
      })
    }
  }
}