import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-right-column-list',
  templateUrl: './right-column-list.component.html',
  styleUrl: './right-column-list.component.scss'
})
export class RightColumnListComponent {
  @Input() table : any[] | undefined = []

  @Output() entityId = new EventEmitter<number | null>()

  currentEntityId : number | null = null

  handleId(entityId : number | null): void {
    this.currentEntityId = entityId
    this.entityId.emit(entityId)
  }
}