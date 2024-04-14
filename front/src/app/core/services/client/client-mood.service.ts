import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable, map } from 'rxjs';
import { MoodsGetAllResponse, MoodsGetOneDetailsResponse, GetMoodsByTagResponse, UpdateMoodScoreResponse, UpdateMoodScoreCall, GetMoodsByArtistResponse, GetMoodsByModelResponse, GetMoodsByFranchiseResponse } from '../../models/mood';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MoodService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Moods/'  

  // - Get All

  public GetAll() : Observable<MoodsGetAllResponse>
  {
    return this.#http.get<MoodsGetAllResponse>(this.#url + 'GetAll')
  }

  // - Get One Details

  public GetOneDetails( moodId : number ) : Observable<MoodsGetOneDetailsResponse>
  {
    return this.#http.get<MoodsGetOneDetailsResponse>(this.#url + 'GetOneDetails/' + moodId)
  }

  // - Get Random

  public GetOneDetailsRandom() : Observable<MoodsGetOneDetailsResponse>
  {
    return this.#http.get<MoodsGetOneDetailsResponse>(this.#url + 'GetOneDetailsRandom/')
  }

  // - Get by Tag

  public GetByTag( tagId : number ) : Observable<GetMoodsByTagResponse>
  {
    return this.#http.get<GetMoodsByTagResponse>(this.#url + 'GetByTag/' + tagId)
  }

  // - Get by Artist

  public GetByArtist( artistId : number ) : Observable<GetMoodsByArtistResponse>
  {
    return this.#http.get<GetMoodsByArtistResponse>(this.#url + 'GetByArtist/' + artistId)
  }

  // - Get by Model

  public GetByModel( modelId : number ) : Observable<GetMoodsByModelResponse>
  {
    return this.#http.get<GetMoodsByModelResponse>(this.#url + 'GetByModel/' + modelId)
  }

  // - Get by Franchise

  public GetByFranchise( franchiseId : number ) : Observable<GetMoodsByFranchiseResponse>
  {
    return this.#http.get<GetMoodsByFranchiseResponse>(this.#url + 'GetByFranchise/' + franchiseId)
  }

  // Update Score

  public UpdateScore( form : UpdateMoodScoreCall )
  {
    return this.#http.put<UpdateMoodScoreResponse>(this.#url + 'UpdateScore', form)
  }
}