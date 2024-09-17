import { Component, Input } from '@angular/core';
import { LinkCategoryFull } from '../../../models/link';

@Component({
  selector: 'app-create-link-category',
  templateUrl: './create-link-category.component.html',
  styleUrl: './create-link-category.component.scss'
})
export class CreateLinkCategoryComponent {
  @Input() linkCategory : LinkCategoryFull | undefined = undefined
}
