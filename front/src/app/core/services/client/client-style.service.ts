import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { GetOneStyleDetailsResponse, StylesCheckResponse, StylesCountResponse, StylesCreateResponse, StylesDeleteResponse, GetAllStylesResponse, StylesUpdateResponse } from '../../models/style';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StyleService 
{
  #http = inject(HttpClient)
  url : string = environment.apiBaseUrl + '/api/V1/'

  #styleId = new BehaviorSubject<number | null>(null)
  styleId$ = this.#styleId.asObservable()

  #stylesCountResponse = new BehaviorSubject<StylesCountResponse | null>(null)
  stylesCountResponse$ = this.#stylesCountResponse.asObservable()

  #stylesCreateResponse = new BehaviorSubject<StylesCreateResponse | null>(null)
  stylesCreateResponse$ = this.#stylesCreateResponse.asObservable()

  #stylesGetAllResponse = new BehaviorSubject<GetAllStylesResponse | null>(null)
  stylesGetAllResponse$ = this.#stylesGetAllResponse.asObservable()

  #stylesGetOneResponse = new BehaviorSubject<GetOneStyleDetailsResponse | null>(null)
  stylesGetOneResponse$ = this.#stylesGetOneResponse.asObservable()

  #stylesCheckResponse = new BehaviorSubject<StylesCheckResponse | null>(null)
  stylesCheckResponse$ = this.#stylesCheckResponse.asObservable()

  #stylesUpdateResponse = new BehaviorSubject<StylesUpdateResponse | null>(null)
  stylesUpdateResponse$ = this.#stylesUpdateResponse.asObservable()

  #stylesDeleteResponse = new BehaviorSubject<StylesDeleteResponse | null>(null)
  stylesDeleteResponse$ = this.#stylesDeleteResponse.asObservable()

  // Style ID

  updateStyleID(styleId : number | null) 
  {
    this.#styleId.next(styleId)
  }

  // Get All

  public GetAll() : Observable<GetAllStylesResponse> 
  {
    return this.#http.get<GetAllStylesResponse>(`${this.url}Styles/GetAll`).pipe( tap(response => { this.#stylesGetAllResponse.next(response) } ))
  }

  // Get One

  public GetOne(styleId : number) : Observable<GetOneStyleDetailsResponse> 
  {
    return this.#http.get<GetOneStyleDetailsResponse>(`${this.url}Styles/GetOneDetails/${styleId}`).pipe( tap(response => { this.#stylesGetOneResponse.next(response) } ))
  }

  // Get Styles Check

  public GetStylesCheck(artistId : number) : Observable<StylesCheckResponse> 
  {
    return this.#http.get<StylesCheckResponse>(`${this.url}Styles/Check/${artistId}`).pipe( tap(response => { this.#stylesCheckResponse.next(response) } ))
  }
}