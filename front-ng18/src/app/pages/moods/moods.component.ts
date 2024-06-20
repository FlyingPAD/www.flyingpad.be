import { Component, inject } from '@angular/core';
import { MoodsListComponent } from '../../features/moods/moods-list/moods-list.component';
import { ActivatedRoute } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';

@Component({
  selector: 'app-moods',
  standalone: true,
  imports: [MoodsListComponent],
  templateUrl: './moods.component.html',
  styleUrl: './moods.component.scss'
})
export class MoodsComponent {
  #activatedRoute = inject(ActivatedRoute);

  moods = toSignal(this.#activatedRoute.data.pipe(
    map( (data : any) => data['moods']) 
  ))
}
