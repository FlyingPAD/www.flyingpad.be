import { Component, Input } from '@angular/core';
import { FranchiseFull } from '../../../models/franchise';

@Component({
  selector: 'app-edit-franchise',
  templateUrl: './edit-franchise.component.html',
  styleUrl: './edit-franchise.component.scss'
})
export class EditFranchiseComponent {
  @Input() franchise! : FranchiseFull | undefined
}
