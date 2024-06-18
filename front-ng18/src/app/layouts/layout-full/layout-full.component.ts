import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuMainFullComponent } from '../../components/menu-main-full/menu-main-full.component';
import { HeaderComponent } from '../../components/header/header.component';
import { OverlayComponent } from '../../components/overlay/overlay.component';

@Component({
  selector: 'app-layout-full',
  standalone: true,
  imports: [RouterOutlet, MenuMainFullComponent, HeaderComponent, OverlayComponent],
  templateUrl: './layout-full.component.html',
  styleUrl: './layout-full.component.scss'
})
export class LayoutFullComponent {

}
