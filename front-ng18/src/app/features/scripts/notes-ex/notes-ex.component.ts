import { Component } from '@angular/core';
import { ButtonTopComponent } from '../../../components/button-top/button-top.component';
import { FlyingKeysMiniComponent } from '../../tools/flying-keys-mini/flying-keys-mini.component';

@Component({
  selector: 'app-notes-ex',
  standalone: true,
  imports: [ButtonTopComponent, FlyingKeysMiniComponent],
  templateUrl: './notes-ex.component.html',
  styleUrl: './notes-ex.component.scss'
})
export class NotesExComponent {

}
