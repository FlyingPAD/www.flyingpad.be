import { Component, Input } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';

@Component({
  selector: 'app-delete-link-category',
  templateUrl: './delete-link-category.component.html',
  styleUrl: './delete-link-category.component.scss'
})
export class DeleteLinkCategoryComponent {
  @Input() linkCategory : LinkCategoryFull | undefined = undefined
}
