import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
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
}