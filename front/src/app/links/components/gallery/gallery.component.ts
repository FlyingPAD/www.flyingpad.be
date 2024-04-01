import { Component, inject } from '@angular/core';
import { LinksStateService } from '../../../core/services/links-state.service';
import { Link } from '../../../core/models/link';

@Component({
  selector: 'app-gallery',
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.scss'
})
export class GalleryComponent 
{
  linksState = inject(LinksStateService)

  // links : Link[] = []

  links$ = this.linksState.links$
}
