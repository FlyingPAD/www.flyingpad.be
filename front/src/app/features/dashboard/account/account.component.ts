import { Component, inject, HostListener, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserService } from '../../../services/http/user.service';
import { Subscription } from 'rxjs';
import { formatDate } from '@angular/common';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrl: './account.component.scss'
})
export class AccountComponent implements OnDestroy {
  #userService = inject(UserService)
  #formBuilder = inject(FormBuilder)

  #subscription = new Subscription()
  public user = this.#userService.user

  public showEdition: boolean = false
  public formGroup: FormGroup = this.#formBuilder.group({
    businessId: [this.user().businessId],
    userName: [this.user().userName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    firstName: [this.user().firstName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    lastName: [this.user().lastName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    birthdate: [formatDate(this.user().birthdate, 'yyyy-MM-dd', 'en_US')]
  })

  ngOnDestroy(): void {
    this.#subscription.unsubscribe
  }

  public toggleEdition(): void {
    this.showEdition = !this.showEdition
  }

  public onSubmit(): void {
    if (this.formGroup.valid) {
      this.#subscription = this.#userService.updateUser(this.formGroup.value).subscribe(() => this.toggleEdition())
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case 'Enter':
        if(this.showEdition) this.onSubmit()
        break
    }
  }
}