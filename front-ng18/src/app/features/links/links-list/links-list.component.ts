import { Component, input } from '@angular/core';
import { Link } from '../../../models/link';
import { FilterPipe } from '../../../pipes/links-filter.pipe';
import { MatListModule } from '@angular/material/list';
import { NgxPaginationModule } from 'ngx-pagination';

@Component({
    selector: 'app-links-list',
    standalone: true,
    templateUrl: './links-list.component.html',
    styleUrl: './links-list.component.scss',
    imports: [FilterPipe, MatListModule, NgxPaginationModule]
})
export class LinksListComponent 
{
  links = input.required<Link[]>();
  search = input('');
  currentPage : number = 1
  linksPerPage : number = 12
}
