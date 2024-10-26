import { Component, inject } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../services/user.service';
import { AuthenticationService } from '../../services/system/authentication.service';
import { ImageUrlService } from '../../services/display/image-url.service';

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrl: './my-account.component.scss'
})
export class MyAccountComponent {
  #authService = inject(AuthenticationService)
  #router = inject(Router)
  #imageUrlService = inject(ImageUrlService)
  userService = inject(UserService)

  public isConnected = this.#authService.isConnected

  public goTo(url : string): void {
    this.#router.navigateByUrl(url)
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}