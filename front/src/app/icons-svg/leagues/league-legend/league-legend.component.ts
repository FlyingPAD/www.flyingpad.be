import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-legend',
  templateUrl: './league-legend.component.html'
})
export class LeagueLegendComponent {
  @Input() size: string = '30px'
}