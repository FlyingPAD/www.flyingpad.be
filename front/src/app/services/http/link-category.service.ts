import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { LinkCategoryCreateForm } from '../../interfaces/forms-create';
import { CreateLinkCategoryResponse } from '../../interfaces/responses-create';
import { LinkCategoryUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class LinkCategoryService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createLinkCategory(form: LinkCategoryCreateForm) {
    return this.#http.post<CreateLinkCategoryResponse>(`${this.#url}LinkCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkCategoryId(response.linkCategoryId)
          this.#flowService.refreshLinkCategories()
        }
        else this.#notificationService.error(response.message)
      })
    )
  }

  public updateLinkCategory(form: LinkCategoryUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}LinkCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkCategoryId(form.linkCategoryId)
          this.#flowService.refreshLinkCategories()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteLinkCategory(linkCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}LinkCategories/Delete/${linkCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateLinkCategoryId(null)
          this.#flowService.refreshLinkCategories()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}