import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HeaderService 
{
  // Properties :

  headerMobileMenuActive : boolean = false

  // Methods :

  headerMobileMenuTrigger() : void
  {
    this.headerMobileMenuActive = !this.headerMobileMenuActive
  }
}