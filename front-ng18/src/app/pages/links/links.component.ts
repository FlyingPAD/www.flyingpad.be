import { Component, inject, signal } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';
import { LinksListComponent } from '../../features/links/links-list/links-list.component';
import { LinkFilterComponent } from '../../features/links/link-filter/link-filter.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-links',
  standalone: true,
  imports: [CommonModule, RouterModule, LinksListComponent, LinkFilterComponent],
  templateUrl: './links.component.html',
  styleUrl: './links.component.scss'
})
export class LinksComponent 
{
  #activatedRoute = inject(ActivatedRoute);

  links = toSignal(this.#activatedRoute.data.pipe(
    map( (data : any) => data['links']) 
  ))
  search = signal('');

  handleSearch(value : string) 
  {
    this.search.set(value)
  }
}