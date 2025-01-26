import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-spacer',
  templateUrl: './spacer.component.html',
  styleUrl: './spacer.component.scss'
})
export class SpacerComponent {
  @Input() height: string = '150px'
}