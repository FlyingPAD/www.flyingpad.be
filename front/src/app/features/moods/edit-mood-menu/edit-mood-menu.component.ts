import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-edit-mood-menu',
  templateUrl: './edit-mood-menu.component.html',
  styleUrl: './edit-mood-menu.component.scss'
})
export class EditMoodMenuComponent {
  @Input() editMoodMenuState : string = 'info'
  @Output() editMoodMenuStateTrigger = new EventEmitter()

  public handleEditMoodMenuState(state: string): void {
    this.editMoodMenuStateTrigger.emit(state)
  }
}