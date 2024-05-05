import { Component, inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.scss']
})
export class UserRegisterComponent 
{
  #router = inject(Router)
  #authService = inject(AuthService)
  #toastr = inject(ToastrService)

  // Properties :

  formGroup : FormGroup = inject(FormBuilder).group({
    firstName: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    lastName: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(50)]],
    birthdate: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email, Validators.maxLength(384)]],
    pass: ['', [Validators.required]],
    confirmPass: ['', [Validators.required]]
  }, {validator: this.passwordMatchValidator})

    // Méthode de validation personnalisée pour vérifier que les mots de passe correspondent

    passwordMatchValidator( fg : FormGroup ) : { [key : string] : boolean } | null 
    {
      const pass = fg.get('pass')?.value
      const confirmPass = fg.get('confirmPass')?.value
      return pass === confirmPass ? null : { 'passwordMismatch': true }
    }

  ngOnInit() : void 
  {
    // Scrolls to the top of the page when the component is initialized.

    window.scrollTo(0, 0)
  }

  onSubmit() : void 
  {
    if (this.formGroup.valid) 
    {
      // Calling the authentication service to register the user.

      this.#authService.register(this.formGroup.value).subscribe({
        next: () => 
        {
          // Displaying a success notification upon successful registration.

          this.#toastr.success('Registration successful. Welcome!', 'Success');

          // Accept Connection

          this.#authService.acceptConnection()

          // Redirecting to the home page after successful registration.

          this.#router.navigate(['/home'])
        },
        error: (_) => 
        { 
          // Using '_' to indicate that the error object is intentionally unused.
          // Displaying an error notification to the user in case of registration failure.

          this.#toastr.error('Registration failed. Please try again.', 'Error')
        }
      })
    }
  }
}