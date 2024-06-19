import { Component, inject } from '@angular/core';
import { Location } from '@angular/common';

@Component({
  selector: 'app-button-back',
  standalone: true,
  imports: [],
  templateUrl: './button-back.component.html',
  styleUrl: './button-back.component.scss'
})
export class ButtonBackComponent 
{
  #location = inject(Location)

  goBack() : void 
  {
    this.#location.back()
  }
}
