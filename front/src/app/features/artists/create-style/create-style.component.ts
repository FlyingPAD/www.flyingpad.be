import { Component, EventEmitter, HostListener, inject, OnDestroy, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { StyleCreateForm } from '../../../interfaces/forms-create';
import { ArtistService } from '../../../services/http/artist.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-create-style',
  templateUrl: './create-style.component.html'
})
export class CreateStyleComponent implements OnDestroy {
  #artistService = inject(ArtistService)
  #formBuilder = inject(FormBuilder)

  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup: FormGroup = this.#formBuilder.group({
    name: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })


  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public createStyle(): void {
    let form: StyleCreateForm = {
      name: this.formGroup.value.name,
      description: this.formGroup.value.description,
    }

    if (this.formGroup.valid) {
      this.#artistService.createStyle(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.createStyle()
        break
    }
  }
}