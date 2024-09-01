import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-right-column-list',
  templateUrl: './right-column-list.component.html',
  styleUrl: './right-column-list.component.scss'
})
export class RightColumnListComponent {
  @Input() table : any[] | undefined = []
  @Input() currentEntityId : number | undefined = undefined

  @Output() entityId = new EventEmitter<number | null>()

  handleId(entityId : number | null): void {
    this.entityId.emit(entityId)
  }
}