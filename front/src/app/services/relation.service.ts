import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { CheckRelationsArtistStyleByArtistResponse, CheckRelationsArtistStyleByStyleResponse, CreateRelationsArtistStyleResponse, CreateRelationsMoodArtistResponse, CreateRelationsMoodModelResponse, CreateRelationsMoodTagResponse, RelationsArtistStyleForm, RelationsMoodArtistForm, RelationsMoodModelForm, RelationsMoodTagForm } from '../models/relations';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RelationService 
{
  #http = inject(HttpClient)
  url : string = environment.apiBaseUrl + '/api/V1/'

  public InsertRMT( rmtForm : RelationsMoodTagForm ) : Observable<CreateRelationsMoodTagResponse> {
    return this.#http.post<CreateRelationsMoodTagResponse>(this.url + 'Relations/MoodTag/Create', rmtForm)
  }
  public InsertRMA( rmaForm : RelationsMoodArtistForm ) : Observable<CreateRelationsMoodArtistResponse> {
    return this.#http.post<CreateRelationsMoodArtistResponse>(this.url + 'Relations/MoodArtist/Create', rmaForm)
  }
  public InsertRMM( rmmForm : RelationsMoodModelForm ) : Observable<CreateRelationsMoodModelResponse> {
    return this.#http.post<CreateRelationsMoodModelResponse>(this.url + 'Relations/MoodModel/Create', rmmForm)
  }
  public InsertRAS( rasForm : RelationsArtistStyleForm ) : Observable<CreateRelationsArtistStyleResponse> {
    return this.#http.post<CreateRelationsArtistStyleResponse>(this.url + 'Relations/ArtistStyle/Create', rasForm)
  }

  public CheckRelationsArtistStyleByArtist( artistId : number ) : Observable<CheckRelationsArtistStyleByArtistResponse> {
    return this.#http.get<CheckRelationsArtistStyleByArtistResponse>(this.url + 'Relations/ArtistStyle/CheckRelationsByArtist?artistId=' + artistId )
  }
  public CheckRelationsArtistStyleByStyle( styleId : number ) : Observable<CheckRelationsArtistStyleByStyleResponse> {
    return this.#http.get<CheckRelationsArtistStyleByStyleResponse>(this.url + 'Relations/ArtistStyle/CheckRelationsByStyle?styleId=' + styleId )
  }
}