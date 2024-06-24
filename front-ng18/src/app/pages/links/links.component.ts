import { Component, HostListener, Signal, inject, input, signal } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';
import { LinksListComponent } from '../../features/links/links-list/links-list.component';
import { LinkFilterComponent } from '../../features/links/link-filter/link-filter.component';
import { CommonModule } from '@angular/common';
import { LinkCategoriesListComponent } from '../../features/links/link-categories-list/link-categories-list.component';
import { Link, LinkCategoryFull, LinkForm } from '../../models/link';
import { LinksService } from '../../services/links.service';
import { LinkFormComponent } from '../../features/links/link-form/link-form.component';
import { LinkDialogComponent } from '../../features/links/link-dialog/link-dialog.component';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-links',
  standalone: true,
  imports: [
    CommonModule, 
    RouterModule, 
    LinksListComponent, 
    LinkFilterComponent, 
    LinkCategoriesListComponent, 
    LinkFormComponent, 
    LinkDialogComponent],
  templateUrl: './links.component.html',
  styleUrl: './links.component.scss'
})
export class LinksComponent 
{
  #router = inject(Router);
  #activatedRoute = inject(ActivatedRoute);
  #linksService = inject(LinksService)
  userService = inject(UserService)
  
  idParam: Signal<string | undefined>
  links = input<Link[]>([]);
  linkCategories = input<LinkCategoryFull[]>([]);
  selectedLink = signal<Link | undefined>(undefined);
  isOpen = signal(false);
  search = signal('');

  constructor() {
    this.idParam = toSignal(this.#activatedRoute.queryParams.pipe(
      map(params => params['category'])
    ));
  }

  handleEdit(link: Link) {
    this.isOpen.set(true);
    this.selectedLink.set(link);
  }

  handleDelete(id: number) {
    this.#linksService.delete(id).subscribe(() => this.reload());
  }
  handleSave(linkForm: LinkForm) {
    this.resetDialog();
    this.#linksService.createOrUpdate(linkForm, this.idParam()).subscribe(() => this.reload());
  }

  handleCloseDialog() {
    this.resetDialog();
  }

  handleSearch(value: string) {
    this.search.set(value)
  }

  toggleDialog() {
    this.isOpen.update(x => !x);
  }

  private resetDialog() {
    this.isOpen.set(false);
    this.selectedLink.set(undefined);
  }

  private reload() {
    const { pathname, search } = window.location;
    const currentUrl = `${pathname}${search}`;
    this.#router.navigateByUrl(currentUrl)
  }

  // TO TOP BUTTON
  topButtonIsActive = false    
  @HostListener('window:scroll', ['$event'])
  onWindowScroll() 
  {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }   
  toTop() : void 
  {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    })
  }
}