import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-list-flow',
  templateUrl: './list-flow.component.html',
  styleUrl: './list-flow.component.scss'
})
export class ListFlowComponent {
  @Input() list : any[] | undefined = undefined
  @Input() property : string | undefined = undefined
  @Output() itemId = new EventEmitter<number>()

  itemListId : number = 0

  handleId(Id : number) : void
  {
    this.itemListId = Id
    this.itemId.emit(Id)
  }
}