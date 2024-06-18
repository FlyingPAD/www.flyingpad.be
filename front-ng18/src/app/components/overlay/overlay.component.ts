import { Component, inject } from '@angular/core';
import { MenuMainService } from '../../services/menu-main.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-overlay',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './overlay.component.html',
  styleUrl: './overlay.component.scss'
})
export class OverlayComponent 
{
  menuMainService = inject(MenuMainService)

  menuTrigger()
  {
    this.menuMainService.triggerMenuCustom()
  }
}
