import { Component, Input } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';

@Component({
  selector: 'app-edit-link-category',
  templateUrl: './edit-link-category.component.html',
  styleUrl: './edit-link-category.component.scss'
})
export class EditLinkCategoryComponent {
  @Input() linkCategory : LinkCategoryFull | undefined = undefined
}
