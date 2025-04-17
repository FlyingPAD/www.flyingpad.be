import { Injectable, signal } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DialogService {
  public dialogToggle = signal<boolean>(false)

  public toggleDialog(): void { this.dialogToggle.update(current => !current) }
}