import { Component } from '@angular/core';
import { ButtonTopComponent } from '../../../components/button-top/button-top.component';

@Component({
  selector: 'app-introduction',
  standalone: true,
  imports: [ButtonTopComponent],
  templateUrl: './introduction.component.html',
  styleUrl: './introduction.component.scss'
})
export class IntroductionComponent {

}
