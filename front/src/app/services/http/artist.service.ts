import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { Observable, tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { ArtistCreateForm } from '../../interfaces/forms-create';
import { CreateArtistResponse } from '../../interfaces/responses-create';
import { ArtistUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class ArtistService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createArtist(form: ArtistCreateForm): Observable<CreateArtistResponse> {
    return this.#http.post<CreateArtistResponse>(`${this.#url}Artists/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateArtistId(response.artistId)
          this.#flowService.refreshArtists()
          this.#flowService.updateStyleId(form.styleIds[0])
        }
        else this.#notificationService.error(response.message)
      })
    )
  }

  public updateArtist(form: ArtistUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Artists/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateArtistId(form.artistId)
          this.#flowService.refreshArtists()
          this.#flowService.updateStyleId(form.styleIds[0])
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteArtist(artistId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Artists/Delete/${artistId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateArtistId(null)
          this.#flowService.refreshArtists()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}