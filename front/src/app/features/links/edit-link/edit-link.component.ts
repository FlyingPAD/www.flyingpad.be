import { Component, Input } from '@angular/core';
import { LinkFull } from '../../../models/link';

@Component({
  selector: 'app-edit-link',
  templateUrl: './edit-link.component.html',
  styleUrl: './edit-link.component.scss'
})
export class EditLinkComponent {
  @Input() link! : LinkFull | undefined
}
