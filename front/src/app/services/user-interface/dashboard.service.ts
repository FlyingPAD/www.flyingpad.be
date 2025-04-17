import { Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { DashboardViewMode } from '../../enumerations/view-modes';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  #dashboardViewMode$ = new BehaviorSubject<DashboardViewMode>(DashboardViewMode.Status)

  public dashboardViewMode = toSignal(this.#dashboardViewMode$) as Signal<DashboardViewMode>
  
  public setDashboardViewMode(viewMode: DashboardViewMode): void {
    this.#dashboardViewMode$.next(viewMode)
  }
}