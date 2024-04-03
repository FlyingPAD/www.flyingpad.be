import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { BehaviorSubject, catchError, combineLatest, debounceTime, map, of, shareReplay, startWith, switchMap } from 'rxjs';
import { FormControl } from '@angular/forms';
import { ArtistsGetPageResponse } from '../models/artist';
import { toSignal } from '@angular/core/rxjs-interop';
import { StyleCheck, StylesGetAllResponse } from '../models/style';

@Injectable({
  providedIn: 'root'
})
export class ArtistsStateService 
{
  // Injections :

  #http = inject(HttpClient)

  // Properties :

  #url : string = environment.apiBaseUrl + '/api/V1/'

  nameSearchField = new FormControl('')

  #selectedStyleId = new BehaviorSubject<number | null>(null)
  selectedStyleId$ = this.#selectedStyleId.asObservable()
  updateCurrentStyleId( styleId : number | null ) { this.#selectedStyleId.next( styleId ) }

  #startId = new BehaviorSubject<number | null>(null)
  startId$ = this.#startId.asObservable()
  updateStartId( startId : number | null ) { this.#startId.next( startId ) }

  styles$ = this.#http.get<StylesGetAllResponse>(`${this.#url}Styles/GetAll`).pipe(
    map(response => response.stylesList),
    startWith([]),
    catchError(() => of([])),
    shareReplay(1)
  )

  artistsFlow$ = combineLatest([
    this.selectedStyleId$,
    this.nameSearchField.valueChanges.pipe(startWith('')),
    this.startId$.pipe(startWith(null)),
    this.styles$.pipe(startWith([]))
  ]).pipe(
    debounceTime(100),
    switchMap(([styleId, searchTerm, startId, styles]) => {
      let params = new HttpParams()
        .set('styleId', styleId?.toString() ?? '')
        .set('startId', startId?.toString() ?? '')
        .set('abc', searchTerm || '')
        .set('pageSize', '20')

      return this.#http.get<ArtistsGetPageResponse>(`${this.#url}Artists/GetPage`, { params })
        .pipe(
          map(response => ({
            ...response,
            selectedStyleId: styleId,
            styles
          }))
        )
    }),
    catchError(error => of({
      success: false,
      message: 'Failed to load artists and styles.' + error,
      validationErrors: [],
      totalItems: 0,
      itemPosition: 0,
      previousId: 0,
      nextId: 0,
      artistsPage: [],
      styles: [],
      selectedStyleId: null
    })),
    shareReplay(1)
  )
  
  artistsFlow = toSignal(this.artistsFlow$, 
  {
    initialValue: {
      success: true,
      message: '',
      validationErrors: [],
      totalItems: 0,
      itemPosition: 0,
      previousId: 0,
      nextId: 0,
      artistsPage: [],
      styles: [],
      selectedStyleId: null
    }
  })
}