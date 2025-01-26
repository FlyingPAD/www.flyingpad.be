import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-edit-mood-form',
  templateUrl: './edit-mood-form.component.html',
  styleUrl: './edit-mood-form.component.scss'
})
export class EditMoodFormComponent {
  @Input() formGroup!: FormGroup
}