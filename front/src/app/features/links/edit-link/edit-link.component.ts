import { Component, EventEmitter, HostListener, inject, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { LinkCategoryCheckBox, LinkFull } from '../../../interfaces/link';
import { LinkUpdateForm } from '../../../interfaces/forms-update';
import { LinkService } from '../../../services/http/link.service';
import { Subject, takeUntil } from 'rxjs';
import { DialogService } from '../../../services/user-interface/dialog.service';

@Component({
  selector: 'app-edit-link',
  templateUrl: './edit-link.component.html'
})
export class EditLinkComponent implements OnInit {
  #linkService = inject(LinkService)
  #dialogService = inject(DialogService)
  #formBuilder = inject(FormBuilder)

  @Input() link: LinkFull | undefined = undefined
  @Output() setViewMode = new EventEmitter<void>()

  #destroy$ = new Subject<void>()

  public formGroup!: FormGroup

  get linkCategoriesArray(): FormArray {
    return this.formGroup.get('linkCategories') as FormArray
  }


  ngOnInit(): void {
    if (this.link) {
      this.formGroup = this.#formBuilder.group({
        name: [this.link.name, [Validators.required, Validators.maxLength(50)]],
        description: [this.link.description, [Validators.required, Validators.maxLength(50)]],
        url: [this.link.url, [Validators.required, Validators.maxLength(100)]],
        linkCategories: this.#formBuilder.array([])
      })

      this.#linkService.getLinkCategoriesCheckBoxes(this.link.businessId)
        .subscribe(categories => this.populateCategories(categories))
    }
  }

  ngOnDestroy(): void {
    this.#destroy$.next()
    this.#destroy$.complete()
  }

  private populateCategories(categories: LinkCategoryCheckBox[]): void {
    categories.forEach(category => {
      this.linkCategoriesArray.push(
        this.#formBuilder.group({
          businessId: category.businessId,
          name: category.name,
          isChecked: category.isChecked || false
        })
      )
    })
  }

  public toggleDialog(): void { this.#dialogService.toggleDialog() }
  public handleSetViewMode(): void { this.setViewMode.emit() }

  public updateLink(): void {
    if (this.formGroup.valid && this.link) {
      let selectedCategories = this.formGroup.value.linkCategories
        .filter((category: { isChecked: boolean }) => category.isChecked)
        .map((category: { businessId: number }) => category.businessId)

      let form: LinkUpdateForm = {
        linkId: this.link.businessId,
        name: this.formGroup.value.name,
        description: this.formGroup.value.description,
        url: this.formGroup.value.url,
        linkCategoryIds: selectedCategories
      }

      this.#linkService.updateLink(form)
        .pipe(takeUntil(this.#destroy$))
        .subscribe(response => { if (response.success) this.setViewMode.emit() })
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        this.updateLink()
        break
    }
  }
}