import { Component, inject } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import {MatListModule} from '@angular/material/list';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-test',
  standalone: true,
  imports: [MatListModule],
  templateUrl: './test.component.html',
  styleUrl: './test.component.scss'
})
export class TestComponent 
{
  games : string[] = [
    'FF7',
    'Super Mario',
    'Cuphead'
  ]

  activatedRoute = inject(ActivatedRoute)

  models = toSignal(this.activatedRoute.data.pipe(
    map( (data : any) => data['models']) 
  ))
}
