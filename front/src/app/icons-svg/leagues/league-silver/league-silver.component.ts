import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-silver',
  templateUrl: './league-silver.component.html'
})
export class LeagueSilverComponent {
  @Input() size: string = '30px'
}