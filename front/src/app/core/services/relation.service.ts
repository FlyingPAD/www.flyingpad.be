import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { CheckRelationsArtistStyleByArtistResponse, CheckRelationsArtistStyleByStyleResponse, CreateRelationsArtistStyleResponse, CreateRelationsMoodTagResponse, RelationsArtistStyleForm, RelationsMoodTagForm } from '../models/relations';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RelationService 
{
  #http = inject(HttpClient)
  url : string = environment.apiBaseUrl + '/api/V1/'

  // Insert Relation ( Mood / Tag )  
  public InsertRMT( rmtForm : RelationsMoodTagForm ) : Observable<CreateRelationsMoodTagResponse>
  {
    return this.#http.post<CreateRelationsMoodTagResponse>(this.url + 'Relations/MoodTag/Create', rmtForm)
  }

  // Insert Relation ( Artist / Style )
  public InsertRAS( rasForm : RelationsArtistStyleForm ) : Observable<CreateRelationsArtistStyleResponse>
  {
    return this.#http.post<CreateRelationsArtistStyleResponse>(this.url + 'Relations/ArtistStyle/Create', rasForm)
  }

  // Check ( Artist / Style ) Relations By Artist ID
  public CheckRelationsArtistStyleByArtist( artistId : number ) : Observable<CheckRelationsArtistStyleByArtistResponse>
  {
    return this.#http.get<CheckRelationsArtistStyleByArtistResponse>(this.url + 'Relations/ArtistStyle/CheckRelationsByArtist?artistId=' + artistId )
  }

  // Check ( Artist / Style ) Relations By Style ID
  public CheckRelationsArtistStyleByStyle( styleId : number ) : Observable<CheckRelationsArtistStyleByStyleResponse>
  {
    return this.#http.get<CheckRelationsArtistStyleByStyleResponse>(this.url + 'Relations/ArtistStyle/CheckRelationsByStyle?styleId=' + styleId )
  }
}