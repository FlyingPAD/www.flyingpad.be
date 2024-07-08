import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-list-central',
  templateUrl: './list-central.component.html',
  styleUrl: './list-central.component.scss'
})
export class ListCentralComponent {
  @Input() table : any[] | undefined = undefined

  elementsPerPage : number = 17
  currentPage : number = 1
}
