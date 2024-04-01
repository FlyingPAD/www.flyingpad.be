import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Observable } from 'rxjs';
import { ArtistCreateForm, ArtistUpdateForm, ArtistsCountResponse, ArtistsCreateResponse, GetOneArtistResponse, ArtistsGetPageResponse, ArtistsUpdateResponse, ArtistsDeleteResponse, GetOneArtistDetailsResponse, GetArtistsByStyleResponse, GetArtistsByMoodResponse } from '../../models/artist';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ArtistService 
{
  #http = inject(HttpClient)
  #url : string = environment.apiBaseUrl + '/api/V1/Artists/'

  // Count

  public Count() : Observable<ArtistsCountResponse> 
  {
    return this.#http.get<ArtistsCountResponse>(`${this.#url}Count`)
  }

  // Create

  public Create( form : ArtistCreateForm ) : Observable<ArtistsCreateResponse> 
  {
    return this.#http.post<ArtistsCreateResponse>(`${this.#url}Create`, form)
  }

  // Get One

  public GetOne( artistId : number ) : Observable<GetOneArtistResponse> 
  {
    return this.#http.get<GetOneArtistResponse>(`${this.#url}GetOne/${artistId}`)
  }

  // Get One ( with Details )

  public GetOneDetails( artistId : number ) : Observable<GetOneArtistDetailsResponse> 
  {
    return this.#http.get<GetOneArtistDetailsResponse>(`${this.#url}GetOneDetails/${artistId}`)
  }

  // Get By Style

  public GetByStyle( businessId : number ) : Observable<GetArtistsByStyleResponse> 
  {
    return this.#http.get<GetArtistsByStyleResponse>(`${this.#url}GetArtists/${businessId}`)
  }

  // Get By Mood

  public GetByMood( businessId : number ) : Observable<GetArtistsByMoodResponse> 
  {
    return this.#http.get<GetArtistsByMoodResponse>(`${this.#url}GetByMood/${businessId}`)
  }

  // Get Page

  GetPage( styleId : number | null = null, startId : number | null = null, abc : string = '', pageSize : number = 20 ) : Observable<ArtistsGetPageResponse> 
  {
    let params = new HttpParams()

    if (styleId !== null) 
    {
        params = params.set('styleId', styleId.toString())
    }

    if (startId !== null) 
    {
        params = params.set('startId', startId.toString())
    }

    if (pageSize !== undefined) 
    {
        params = params.set('pageSize', pageSize.toString())
    }

    params = params.set('abc', abc)

    return this.#http.get<ArtistsGetPageResponse>(`${this.#url}GetPage`, { params } )
  }
  
  // Update

  public Update( form : ArtistUpdateForm ) : Observable<ArtistsUpdateResponse>
  {
    return this.#http.put<ArtistsUpdateResponse>(`${this.#url}Update`, form)
  }
  
  // Delete
  
  public Delete( artistId : number ) : Observable<ArtistsDeleteResponse>
  {
    return this.#http.delete<ArtistsDeleteResponse>(`${this.#url}Delete/${artistId}`)
  }
}