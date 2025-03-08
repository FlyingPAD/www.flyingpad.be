import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subscription } from 'rxjs';
import { MediumCreateForm } from '../../../interfaces/forms-create';
import { MediumService } from '../../../services/http/medium.service';

@Component({
  selector: 'app-create-medium',
  templateUrl: './create-medium.component.html',
  styleUrl: './create-medium.component.scss'
})
export class CreateMediumComponent implements OnDestroy {
  @Output() trigger = new EventEmitter<void>()

  #mediumService = inject(MediumService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()
  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })

  ngOnDestroy(): void {
    this.#subscription.unsubscribe()
  }

  public onSubmit(): void {
    let form: MediumCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#subscription = this.#mediumService.createMedium(form).subscribe((response) => {
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