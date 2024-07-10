import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-dialog-info',
  templateUrl: './dialog-info.component.html',
  styleUrl: './dialog-info.component.scss'
})
export class DialogInfoComponent {
  @Input() entity : any | undefined = undefined 
  @Input() moodsLength : number | undefined = 0
  @Input() moodsGalleryType : string = 'all'
}