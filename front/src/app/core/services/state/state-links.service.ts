import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Link } from '../../models/link';
import { LinkCategoryFull, LinkCategoryLight } from '../../models/link-category';

@Injectable({
  providedIn: 'root'
})
export class StateLinksService 
{
  // Properties :

  #totalLinksSubject = new BehaviorSubject<Link[]>([])
  #currentlinksSubject = new BehaviorSubject<Link[]>([])
  #currentlinkSubject =  new BehaviorSubject<Link>(new Link())

  #totalLinkCategoriesSubject = new BehaviorSubject<LinkCategoryLight[]>([])
  #currentlinkCategorySubject = new BehaviorSubject<LinkCategoryFull>(new LinkCategoryFull())

  // Getters :
  
  get totalLinks$()          { return this.#totalLinksSubject.asObservable() }
  get currentLinks$()        { return this.#currentlinksSubject.asObservable() }
  get currentLink$()         { return this.#currentlinkSubject.asObservable() }

  get totalLinkCategories$() { return this.#totalLinkCategoriesSubject.asObservable() }
  get currentLinkCategory$() { return this.#currentlinkCategorySubject.asObservable() }

  // Methods :

  updateTotalLinks( links : Link[] ) 
  {
    this.#totalLinksSubject.next( links )
  }

  updateCurrentLinks( links : Link[] ) 
  {
    this.#currentlinksSubject.next( links )
  }

  updateCurrentLink( link : Link ) 
  {
    this.#currentlinkSubject.next( link )
  }

  updateTotalLinkCategories( linkCategories : LinkCategoryLight[] ) 
  {
    this.#totalLinkCategoriesSubject.next( linkCategories )
  }

  updateCurrentLinkCategory( linkCategory : LinkCategoryFull ) 
  {
    this.#currentlinkCategorySubject.next( linkCategory )
  }

}