import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  @Input() isMenuON : boolean = false
  @Input() userIsConnected : boolean | null = false
  @Output() menuTriggerEmitter = new EventEmitter()
  @Output() loginTriggerEmitter = new EventEmitter()
  @Output() logoutTriggerEmitter = new EventEmitter()

  handleMenuTrigger(): void {
    this.menuTriggerEmitter.emit()
  }
  handleLoginTrigger(): void {
    this.loginTriggerEmitter.emit()
  }
  handleLogoutTrigger(): void {
    this.logoutTriggerEmitter.emit()
  }
}