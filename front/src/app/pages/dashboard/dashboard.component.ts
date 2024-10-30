import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';
import { UserService } from '../../services/user.service';
import { User } from '../../interfaces/user';
import { Player } from '../../models/player';
import { FlowService } from '../../services/flow.service';
import { environment } from '../../../environments/environment';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  #imageURLService = inject(ImageUrlService)
  #userService = inject(UserService)
  #flowService = inject(FlowService)

  environment : string = environment.apiBaseUrl
  
  flow = this.#flowService.flow
  user : User = this.#userService.appUser
  player : Player = this.#userService.player

  public isStatusMenuOn : boolean = true
  public isEditionMenuOn : boolean = false
  public isMyAccountMenuOn : boolean = false

  private closeAllMenus(): void {
    this.isMyAccountMenuOn = false
    this.isEditionMenuOn = false
    this.isStatusMenuOn = false
  }
  public openStatusMenu(): void {
    this.closeAllMenus()
    this.isStatusMenuOn = true
  }
  public openEditionMenu(): void {
    this.closeAllMenus()
    this.isEditionMenuOn = true
  }
  public openMyAccountMenu(): void {
    this.closeAllMenus()
    this.isMyAccountMenuOn = true
  }
  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}