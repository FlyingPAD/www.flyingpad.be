import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-right-column-generic-list',
  templateUrl: './right-column-generic-list.component.html',
  styleUrl: './right-column-generic-list.component.scss'
})
export class RightColumnGenericListComponent {
  @Input() items : any[] = []
  @Input() selectedItemId : number | undefined
  @Output() setSelectedItemId = new EventEmitter<number | undefined>()

  public handleSetSelectedItemId(itemId : number | undefined): void {
    this.selectedItemId = itemId
    this.setSelectedItemId.emit(itemId)
  }
}