import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';
import { AuthenticationService } from '../../services/authentication.service';
import { ImageUrlService } from '../../services/image-url.service';

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrl: './my-account.component.scss'
})
export class MyAccountComponent {
  authService = inject(AuthenticationService)
  userService = inject(UserService)
  imageUrlService = inject(ImageUrlService)
  #router = inject(Router)

  goTo(url : string): void {
    this.#router.navigateByUrl(url)
  }

  getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}