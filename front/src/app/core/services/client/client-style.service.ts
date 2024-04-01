import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { StyleCreateForm, StyleUpdateForm, StylesCheckResponse, StylesCountResponse, StylesCreateResponse, StylesDeleteResponse, StylesGetAllResponse, StylesGetOneResponse, StylesUpdateResponse } from '../../models/style';
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

  #stylesGetAllResponse = new BehaviorSubject<StylesGetAllResponse | null>(null)
  stylesGetAllResponse$ = this.#stylesGetAllResponse.asObservable()

  #stylesGetOneResponse = new BehaviorSubject<StylesGetOneResponse | null>(null)
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

  // Count

  public Count() : Observable<StylesCountResponse>
  {
    return this.#http.get<StylesCountResponse>(`${this.url}Styles/Count`).pipe( tap(response => { this.#stylesCountResponse.next(response) } ))
  }

  // Create

  public Create( form : StyleCreateForm ) : Observable<StylesCreateResponse> 
  {
    return this.#http.post<StylesCreateResponse>(`${this.url}Styles/Create`, form).pipe( tap(response => { this.#stylesCreateResponse.next(response) } ))
  }

  // Get All

  public GetAll() : Observable<StylesGetAllResponse> 
  {
    return this.#http.get<StylesGetAllResponse>(`${this.url}Styles/GetAll`).pipe( tap(response => { this.#stylesGetAllResponse.next(response) } ))
  }

  // Get One

  public GetOne(styleId : number) : Observable<StylesGetOneResponse> 
  {
    return this.#http.get<StylesGetOneResponse>(`${this.url}Styles/GetOne/${styleId}`).pipe( tap(response => { this.#stylesGetOneResponse.next(response) } ))
  }

  // Get Styles Check

  public GetStylesCheck(artistId : number) : Observable<StylesCheckResponse> 
  {
    return this.#http.get<StylesCheckResponse>(`${this.url}Styles/Check/${artistId}`).pipe( tap(response => { this.#stylesCheckResponse.next(response) } ))
  }

  // Update

  public Update( form : StyleUpdateForm ) : Observable<StylesUpdateResponse>
  {
    return this.#http.put<StylesUpdateResponse>(`${this.url}Styles/Update`, form).pipe( tap(response => { this.#stylesUpdateResponse.next(response) } ))
  }
  
  // Delete
  
  public Delete( styleId : number ) : Observable<StylesDeleteResponse>
  {
    return this.#http.delete<StylesDeleteResponse>(`${this.url}Styles/Delete/${styleId}`).pipe( tap(response => { this.#stylesDeleteResponse.next(response) } ))
  }
}