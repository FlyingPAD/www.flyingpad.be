import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-stone',
  templateUrl: './league-stone.component.html'
})
export class LeagueStoneComponent {
  @Input() size: string = '30px'
}