import { Directive, HostListener, inject } from '@angular/core';
import { DialogService } from '../services/user-interface/dialog.service';

@Directive({
  selector: '[appToggleDialog]'
})
export class ToggleDialogDirective {
  #dialogService = inject(DialogService)

  @HostListener('click')
  @HostListener('window:keydown', ['$event'])
  toggleMoodInfo(event?: KeyboardEvent): void {
    if (!event || event.key === 'Control') {
      this.#dialogService.toggleDialog()
    }
  }
}