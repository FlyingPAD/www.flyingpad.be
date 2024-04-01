import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Style } from '../../models/style';
import { ArtistLight, ArtistDetails, ArtistsGetPageResponse } from '../../models/artist';


@Injectable({
  providedIn: 'root'
})
export class StateArtistService 
{
  // Properties :

  #nameSearchField =        new BehaviorSubject<string>('')
  #artistsGetPageResponse = new BehaviorSubject<ArtistsGetPageResponse>(new ArtistsGetPageResponse())
  #totalArtists =           new BehaviorSubject<ArtistLight[]>([])
  #currentArtists =         new BehaviorSubject<ArtistLight[]>([])
  #currentArtist =          new BehaviorSubject<ArtistDetails>(new ArtistDetails())
  #totalStyles =            new BehaviorSubject<Style[]>([])
  #currentStyle =           new BehaviorSubject<Style>(new Style())
  #currentStyleId =         new BehaviorSubject<number | null>(null)
  #currentStartId =         new BehaviorSubject<number | null>(null)

  // Getters :

  get nameSearchField$()       { return this.#nameSearchField.asObservable() }
  get artistGetPageResponse$() { return this.#artistsGetPageResponse.asObservable() }
  get totalArtist$()           { return this.#totalArtists.asObservable() }
  get currentArtists$()        { return this.#currentArtists.asObservable() }
  get currentArtist$()         { return this.#currentArtist.asObservable() }
  get totalStyles$()           { return this.#totalStyles.asObservable() }
  get currentStyle$()          { return this.#currentStyle.asObservable() }
  get currentStyleId$()        { return this.#currentStyleId.asObservable() }
  get currentStartId$()        { return this.#currentStartId.asObservable() }

  // Methods :

  updateGetPageResponse( response : ArtistsGetPageResponse) 
  {
    this.#artistsGetPageResponse.next(response)
  }

  updateNameSearchField( searchField : string) 
  {
    this.#nameSearchField.next(searchField)
  }

  updateTotalArtists( artists : ArtistLight[] ) 
  {
    this.#totalArtists.next( artists )
  }

  updateCurrentArtists( artists : ArtistLight[] ) 
  {
    this.#currentArtists.next( artists )
  }

  updateCurrentArtist( artist : ArtistDetails ) 
  {
    this.#currentArtist.next( artist )
  }

  updateTotalStyles( styles : Style[] ) 
  {
    this.#totalStyles.next( styles )
  }

  updateCurrentStyle( style : Style ) 
  {
    this.#currentStyle.next( style )
  }

  updateCurrentStyleId( styleId : number | null ) 
  {
    this.#currentStyleId.next( styleId )
  }

  updateCurrentStartId(startId: number | null) 
  {
    this.#currentStartId.next(startId)
  }
}