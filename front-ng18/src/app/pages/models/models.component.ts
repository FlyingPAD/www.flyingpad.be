import { Component, inject } from '@angular/core';
import { ModelsListComponent } from '../../features/models/models-list/models-list.component';
import { ActivatedRoute } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

@Component({
  selector: 'app-models',
  standalone: true,
  imports: [ModelsListComponent, MatSlideToggleModule],
  templateUrl: './models.component.html',
  styleUrl: './models.component.scss'
})
export class ModelsComponent 
{
  activatedRoute = inject(ActivatedRoute)

  models = toSignal(this.activatedRoute.data.pipe(
    map( (data : any) => data['models']) 
  ))
}
