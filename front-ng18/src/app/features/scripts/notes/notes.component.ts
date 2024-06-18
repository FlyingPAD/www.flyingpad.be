import { Component } from '@angular/core';
import { ButtonTopComponent } from '../../../components/button-top/button-top.component';

@Component({
  selector: 'app-notes',
  standalone: true,
  imports: [ButtonTopComponent],
  templateUrl: './notes.component.html',
  styleUrl: './notes.component.scss'
})
export class NotesComponent {

}
