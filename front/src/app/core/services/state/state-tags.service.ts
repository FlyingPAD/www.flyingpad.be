import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { MiniTag, Tag, TagList } from '../../models/tag';

@Injectable({
  providedIn: 'root'
})
export class StateTagsService 
{
  // Properties :

  #currentTagsListSubject = new BehaviorSubject<TagList[]>( [] )
  #currentTagSubject =  new BehaviorSubject<Tag>( new Tag() )
  #currentTagsByMood = new BehaviorSubject<MiniTag[]>( [] )

  // Getters :
  
  get currentTagList$()  { return this.#currentTagsListSubject.asObservable() }
  get currentTag$()  { return this.#currentTagSubject.asObservable() }
  get currentTagsByMood$() { return this.#currentTagsByMood.asObservable() }

  // Methods :

  updateCurrentTagList( tagList : TagList[] ) 
  {
    this.#currentTagsListSubject.next( tagList )
  }

  updateCurrentTag( tag : Tag ) 
  {
    this.#currentTagSubject.next( tag )
  }

  updateCurrentTagsByMood( tags : MiniTag[] ) 
  {
    this.#currentTagsByMood.next( tags )
  }

}