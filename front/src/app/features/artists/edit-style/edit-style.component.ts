import { Component, EventEmitter, HostListener, inject, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { StyleUpdateForm } from '../../../interfaces/http/forms-update';
import { ArtistService } from '../../../services/http/artist.service';
import { StyleFull } from '../../../interfaces/artist';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-style',
  templateUrl: './edit-style.component.html'
})
export class EditStyleComponent implements OnInit, OnDestroy {
  #artistService = inject(ArtistService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() style: StyleFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup

  ngOnInit(): void {
    this.formGroup = this.#formBuilder.group({
      name: [this.style?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
      description: [this.style?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
    })
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateStyle(): void {
    if (this.formGroup.valid && this.style) {
      let form: StyleUpdateForm = {
        styleId: this.style.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description
      }

      if (this.formGroup.valid) {
        this.#artistService.updateStyle(form)
          .pipe(takeUntil(this.#destroy$))
          .subscribe((response) => { if (response.success) this.setViewMode.emit() })
      }
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateStyle()
        break
    }
  }
}