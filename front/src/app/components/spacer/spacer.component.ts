import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-spacer',
  templateUrl: './spacer.component.html'
})
export class SpacerComponent {
  @Input() height: string = '150px'
}