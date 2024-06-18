import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layout-empty',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './layout-empty.component.html',
  styleUrl: './layout-empty.component.scss'
})
export class LayoutEmptyComponent {

}
