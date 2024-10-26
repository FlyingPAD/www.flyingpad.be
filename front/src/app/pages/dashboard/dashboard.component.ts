import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';
import { UserService } from '../../services/user.service';
import { User } from '../../interfaces/user';
import { Player } from '../../models/player';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  #imageURLService = inject(ImageUrlService)
  #userService = inject(UserService)
  user : User = this.#userService.appUser
  player : Player = this.#userService.player

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}