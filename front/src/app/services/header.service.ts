import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HeaderService 
{
  headerMobileMenuActive : boolean = false

  headerMobileMenuTrigger(): void {
    this.headerMobileMenuActive = !this.headerMobileMenuActive
  }
}