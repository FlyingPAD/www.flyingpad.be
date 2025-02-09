import { inject, Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  #toastr = inject(ToastrService)

  // Generic Messages
  public success(message: string, title?: string): void {
    this.#toastr.success(message, title)
  }

  public error(message: string, title?: string): void {
    this.#toastr.error(message, title)
  }

  public info(message: string, title?: string): void {
    this.#toastr.info(message, title)
  }

  public warning(message: string, title?: string): void {
    this.#toastr.warning(message, title)
  }

  // Custom Messages

  public messageLogout(): void {
    this.#toastr.success('See you soon !')
  }
}