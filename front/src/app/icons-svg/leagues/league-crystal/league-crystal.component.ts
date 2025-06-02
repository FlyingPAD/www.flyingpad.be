import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-league-crystal',
  templateUrl: './league-crystal.component.html'
})
export class LeagueCrystalComponent {
  @Input() size: string = '30px'
}