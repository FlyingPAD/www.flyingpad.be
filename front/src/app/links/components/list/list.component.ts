import { Component, OnInit, OnDestroy, inject } from '@angular/core';
import { Subscription } from 'rxjs';
import { LinkService } from '../../../core/services/client/client-link.service';
import { LinkCategoryService } from '../../../core/services/client/client-link-category.service';
import { StateLinksService } from '../../../core/services/state/state-links.service';
import { MenuMobileService } from '../../../core/services/system/menu-mobile.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit, OnDestroy
{
  #stateLinksService = inject(StateLinksService)
  #linksService = inject(LinkService)
  #linkCategoriesService = inject(LinkCategoryService)
  menuMobileService = inject(MenuMobileService)

  // Properties :

  totalLinks$ = this.#stateLinksService.totalLinks$
  totalLinkCategories$ = this.#stateLinksService.totalLinkCategories$
  
  currentLinks$ = this.#stateLinksService.currentLinks$
  currentLinkCategory$ = this.#stateLinksService.currentLinkCategory$

  linkCategoryId : number | null = null

  #subscription = new Subscription()

  itemsPerPage : number = 20   // Pagination
  currentPage : number = 1     // Pagination

  // Methods :

  ngOnInit() : void 
  {
    
  }

  ngOnDestroy() : void 
  {
    this.#subscription.unsubscribe();
  }

  loadLinks( categoryId : number ) : void 
  {
    this.linkCategoryId = categoryId

    this.#subscription = this.#linksService.GetByCategory( this.linkCategoryId ).subscribe({
      next : (data) => 
      {
        this.#stateLinksService.updateCurrentLinks(data.linksListByCategory)

        this.#linkCategoriesService.GetOneDetails( categoryId ).subscribe({
          next : ( data ) => {
            this.#stateLinksService.updateCurrentLinkCategory( data.linkCategory )
          }
        })
      }
    })
  }

  allLinks()
  {
    this.linkCategoryId = null
  }
  
}