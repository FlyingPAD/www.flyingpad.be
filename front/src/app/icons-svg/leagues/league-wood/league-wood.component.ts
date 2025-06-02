import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-wood',
  templateUrl: './league-wood.component.html'
})
export class LeagueWoodComponent {
  @Input() size: string = '30px'
}