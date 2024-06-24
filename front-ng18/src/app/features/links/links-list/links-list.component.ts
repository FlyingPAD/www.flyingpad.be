import { Component, effect, inject, input, output } from '@angular/core';
import { Link } from '../../../models/link';
import { LinksFilterPipe } from '../../../pipes/links-filter.pipe';
import { MatListModule } from '@angular/material/list';
import { NgxPaginationModule } from 'ngx-pagination';
import { UserService } from '../../../services/user.service';

@Component({
    selector: 'app-links-list',
    standalone: true,
    templateUrl: './links-list.component.html',
    styleUrl: './links-list.component.scss',
    imports: [LinksFilterPipe, MatListModule, NgxPaginationModule]
})
export class LinksListComponent 
{
  userService = inject(UserService)
  links = input.required<Link[]>();
  search = input('');
  edit = output<Link>();
  delete = output<number>();
  currentPage : number = 1
  linksPerPage : number = 14

  handleEdit(link : Link) 
  {
    this.edit.emit(link);
  }

  handleDelete(id : number) 
  {
    this.delete.emit(id);
  }
}
