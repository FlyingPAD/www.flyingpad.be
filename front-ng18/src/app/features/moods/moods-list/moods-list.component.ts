import { Component, inject, input } from '@angular/core';
import { MoodLight } from '../../../models/mood';
import { environment } from '../../../../environments/environment.prod';
import { NgxPaginationModule } from 'ngx-pagination';
import { PaginationService } from '../../../services/pagination.service';

@Component({
  selector: 'app-moods-list',
  standalone: true,
  imports: [NgxPaginationModule],
  templateUrl: './moods-list.component.html',
  styleUrl: './moods-list.component.scss'
})
export class MoodsListComponent {
  paginationService = inject(PaginationService)
  moods = input.required<MoodLight[]>()
  environment : string = environment.apiBaseUrl  
  moodsPerPage : number = 36  
}
