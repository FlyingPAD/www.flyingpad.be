import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/display/image-url.service';
import { UserService } from '../../services/user.service';
import { User } from '../../interfaces/user';
import { Player } from '../../models/player';
import { FlowService } from '../../services/flow.service';
import { environment } from '../../../environments/environment';
import { DashboardService } from '../../services/dashboard.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  #imageURLService = inject(ImageUrlService)
  #userService = inject(UserService)
  #flowService = inject(FlowService)
  dashboardService = inject(DashboardService)

  environment : string = environment.apiBaseUrl
  
  flow = this.#flowService.flow
  user : User = this.#userService.appUser
  player : Player = this.#userService.player

  public isStatusMenuOn : boolean = this.dashboardService.isStatusMenuOn
  public isEditionMenuOn : boolean = this.dashboardService.isEditionMenuOn
  public isMyAccountMenuOn : boolean = this.dashboardService.isMyAccountMenuOn

  private syncMenuStates(): void {
    this.isStatusMenuOn = this.dashboardService.isStatusMenuOn
    this.isEditionMenuOn = this.dashboardService.isEditionMenuOn
    this.isMyAccountMenuOn = this.dashboardService.isMyAccountMenuOn
  }
    public openStatusMenu(): void {
    this.dashboardService.openStatusMenu()
    this.syncMenuStates()
  }
  public openEditionMenu(): void {
    this.dashboardService.openEditionMenu()
    this.syncMenuStates()
  }
  public openMyAccountMenu(): void {
    this.dashboardService.openMyAccountMenu()
    this.syncMenuStates()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}