import { Component, OnDestroy, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from '../../../core/services/client/client-user.service';
import { formatDate } from '@angular/common';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-user-update',
  templateUrl: './user-update.component.html',
  styleUrls: ['./user-update.component.scss']
})
export class UserUpdateComponent implements OnInit, OnDestroy
{
  #userService = inject(UserService)
  #router = inject(Router)

  #updateSubscription = new Subscription()

  // - Properties :

  formGroup : FormGroup = inject(FormBuilder).group
  ({
    created : [ this.#userService.appUser.created ],
    modified : [ this.#userService.appUser.modified ],
    businessId : [ this.#userService.appUser.businessId ],
    firstName : [ this.#userService.appUser.firstName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    lastName : [ this.#userService.appUser.lastName, [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    birthdate : [ formatDate(this.#userService.appUser.birthdate, 'yyyy-MM-dd', 'en_US') ]
  })

  // - Methods :

  ngOnInit() : void 
  {
    
  }

  ngOnDestroy() : void 
  {
    this.#updateSubscription.unsubscribe
  }

  onSubmit() : void 
  {
    if( this.formGroup.valid )
    {      
      this.#updateSubscription = this.#userService.UpdateOneUser(this.formGroup.value ).subscribe
      ({
        next : (data) => 
        {
          this.#userService.appUser.modified = data.updatedUser.modified
          this.#userService.appUser.firstName = data.updatedUser.firstName 
          this.#userService.appUser.lastName = data.updatedUser.lastName 
          this.#userService.appUser.birthdate = data.updatedUser.birthdate 

          this.#router.navigateByUrl("users/user-details") 
        },
        error : (e) => console.error(e),
      }) 
    }
  }
}