import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable, tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { LinkCreateForm } from '../../interfaces/forms-create';
import { LinkUpdateForm } from '../../interfaces/forms-update';
import { CreateLinkResponse } from '../../interfaces/responses-create';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';

@Injectable({
  providedIn: 'root'
})
export class LinkService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createLink(form: LinkCreateForm): Observable<CreateLinkResponse> {
    return this.#http.post<CreateLinkResponse>(`${this.#url}Links/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkId(response.linkId)
          this.#flowService.refreshLinks()
          this.#flowService.updateLinkCategoryId(form.linkCategoryIds[0])
        }
        else this.#notificationService.error(response.message)
      })
    )
  }

  public updateLink(form: LinkUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Links/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkId(form.linkId)
          this.#flowService.refreshLinks()
          this.#flowService.updateLinkCategoryId(form.linkCategoryIds[0])
          this.#flowService.refreshLinkCategories()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteLink(linkId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Links/Delete/${linkId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkId(null)
          this.#flowService.refreshLinks()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}