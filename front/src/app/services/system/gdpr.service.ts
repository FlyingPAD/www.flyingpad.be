import { inject, Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject } from 'rxjs';
import { StorageService } from './storage.service';

@Injectable({
  providedIn: 'root'
})
export class GdprService {
  #storageService = inject(StorageService)
  #toastr = inject(ToastrService)

  #currentStatus = new BehaviorSubject<boolean | undefined | null>(undefined)
  public currentStatus: Signal<boolean | undefined | null> = toSignal(this.#currentStatus)

  constructor() {
    let storedStatus: boolean | null = this.#storageService.getItem('gdpr')

    if (storedStatus) {
      this.setCurrentStatus(storedStatus)
    } else {
      this.#currentStatus.next(undefined)
    }
  }

  public setCurrentStatus(gdprStatus: boolean | undefined | null): void {
      this.#currentStatus.next(gdprStatus)
      this.#storageService.setItem('gdpr', gdprStatus)
  }
}