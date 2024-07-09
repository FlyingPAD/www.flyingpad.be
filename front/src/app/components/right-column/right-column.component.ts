import { Component, inject } from '@angular/core';
import { RightColumnService } from '../../services/right-column.service';

@Component({
  selector: 'app-right-column',
  templateUrl: './right-column.component.html',
  styleUrl: './right-column.component.scss'
})
export class RightColumnComponent {
  // Injection du service
  rightColumnService = inject(RightColumnService);
  rightColumnIsActive : boolean | undefined = false

  constructor() {
    // Récupération de l'état initial depuis le service
    this.rightColumnIsActive = this.rightColumnService.rightColumnIsActive();
  }

  // Méthode pour activer ou désactiver la colonne
  menuTrigger(): void {
    this.rightColumnService.updateRightColumnState(!this.rightColumnIsActive);
    this.rightColumnIsActive = this.rightColumnService.rightColumnIsActive();
  }
}