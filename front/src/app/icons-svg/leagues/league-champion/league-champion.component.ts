import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-champion',
  templateUrl: './league-champion.component.html'
})
export class LeagueChampionComponent {
  @Input() size: string = '30px'
}