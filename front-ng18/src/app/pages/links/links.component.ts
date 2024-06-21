import { Component, Signal, inject, input, signal } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';
import { LinksListComponent } from '../../features/links/links-list/links-list.component';
import { LinkFilterComponent } from '../../features/links/link-filter/link-filter.component';
import { CommonModule } from '@angular/common';
import { LinkCategoriesListComponent } from '../../features/links/link-categories-list/link-categories-list.component';
import { Link, LinkCategoryLight } from '../../models/link';

@Component({
  selector: 'app-links',
  standalone: true,
  imports: [CommonModule, RouterModule, LinksListComponent, LinkFilterComponent, LinkCategoriesListComponent],
  templateUrl: './links.component.html',
  styleUrl: './links.component.scss'
})
export class LinksComponent 
{
  #activatedRoute = inject(ActivatedRoute)

  links = input<Link[]>([])
  linkCategories = input<LinkCategoryLight[]>([])
  idParam: Signal<string | undefined>
  selectedLink = signal<Link | undefined>(undefined)
  search = signal('')

  constructor() {
    this.idParam = toSignal(this.#activatedRoute.queryParams.pipe(
      map(params => params['category'])
    ))
  }

  handleSearch(value : string) {
    this.search.set(value)
  }
}