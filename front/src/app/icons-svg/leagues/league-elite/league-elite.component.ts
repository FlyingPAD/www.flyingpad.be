import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-elite',
  templateUrl: './league-elite.component.html'
})
export class LeagueEliteComponent {
  @Input() size: string = '30px'
}