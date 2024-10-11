import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-menu-hidden',
  templateUrl: './menu-hidden.component.html',
  styleUrl: './menu-hidden.component.scss'
})
export class MenuHiddenComponent {  
  @Input() isMenuON : boolean = false
  @Input() userIsConnected : boolean | null = false
  @Input() userRole : number = 0
  @Output() menuTriggerCustomEmitter = new EventEmitter()
  @Output() menuTriggerEmitter = new EventEmitter()

  currentYear: number = new Date().getFullYear()

  public handleMenuTrigger(): void {
    this.menuTriggerEmitter.emit()
  }
  public handleMenuCustomTrigger(): void {
    this.menuTriggerCustomEmitter.emit()
  }
}