import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ModalService {
  modal: boolean = false

  modalTrigger() {
    this.modal = !this.modal
  }
}