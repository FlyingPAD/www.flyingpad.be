import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  #dashboardMenuState = new BehaviorSubject<string>('status')

  public dashboardMenuState = toSignal(this.#dashboardMenuState) as Signal<string>
  
  public updateMenuState(menuState : string): void {
    this.#dashboardMenuState.next(menuState)
  }
}