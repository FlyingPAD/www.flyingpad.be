import { Component, inject } from '@angular/core';
import { LinksService } from '../../../core/services/links.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrl: './list.component.scss'
})
export class ListComponent 
{
  linksService = inject(LinksService)

  linksFlow = this.linksService.links

  mpp : number = 36
  p : number = 1

  updateLinkId( linkId : number )
  {

  }
}
