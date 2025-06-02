import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-bronze',
  templateUrl: './league-bronze.component.html'
})
export class LeagueBronzeComponent {
  @Input() size: string = '30px'
}