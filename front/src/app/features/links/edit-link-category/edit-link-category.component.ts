import { Component, EventEmitter, HostListener, inject, Input, OnChanges, OnDestroy, Output, SimpleChanges } from '@angular/core';
import { LinkCategoryFull } from '../../../interfaces/link';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Subject, takeUntil } from 'rxjs';
import { LinkCategoryUpdateForm } from '../../../interfaces/http/forms-update';
import { LinkService } from '../../../services/http/link.service';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-link-category',
  templateUrl: './edit-link-category.component.html'
})
export class EditLinkCategoryComponent implements OnChanges, OnDestroy {
  #linkService = inject(LinkService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() linkCategory: LinkCategoryFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup: FormGroup = this.#formBuilder.group({
    name: [this.linkCategory?.name, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    description: [this.linkCategory?.description, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]]
  })


  ngOnChanges(changes: SimpleChanges): void {
    if (changes['linkCategory'] && this.linkCategory) {
      this.formGroup.patchValue({
        name: this.linkCategory.name,
        description: this.linkCategory.description
      })
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateLinkCategory(): void {
    let form: LinkCategoryUpdateForm = {
      linkCategoryId: this.linkCategory ? this.linkCategory.businessId : 0,
      name: this.formGroup.value.name,
      description: this.formGroup.value.description
    }

    if (this.formGroup.valid) {
      this.#linkService.updateLinkCategory(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe((response) => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateLinkCategory()
        break
    }
  }
}