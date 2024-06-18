import { Component, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs';
import { ButtonTopComponent } from '../../components/button-top/button-top.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-tags',
  standalone: true,
  imports: [CommonModule, ButtonTopComponent],
  templateUrl: './tags.component.html',
  styleUrl: './tags.component.scss'
})
export class TagsComponent 
{
  activatedRoute = inject(ActivatedRoute)

  tags = toSignal(this.activatedRoute.data.pipe(
    map( (data : any) => data['tags']) 
  ))
}
