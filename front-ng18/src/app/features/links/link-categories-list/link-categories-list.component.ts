import { Component, inject, input } from '@angular/core';
import { LinkCategoryLight } from '../../../models/link';
import { Router, RouterModule } from '@angular/router';
import { RightColumnService } from '../../../services/right-column.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-link-categories-list',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './link-categories-list.component.html',
  styleUrl: './link-categories-list.component.scss'
})
export class LinkCategoriesListComponent {
  rightColumn = inject(RightColumnService)
  linkCategories = input.required<LinkCategoryLight[]>()

  menuTrigger() : void {
    this.rightColumn.menuRActive = !this.rightColumn.menuRActive
  }
}
