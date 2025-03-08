import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { StyleCreateForm } from '../../interfaces/forms-create';
import { tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { CreateStyleResponse } from '../../interfaces/responses-create';
import { StyleUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class StyleService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createStyle(form: StyleCreateForm) {
    return this.#http.post<CreateStyleResponse>(`${this.#url}Styles/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateStyleId(response.styleId)
          this.#flowService.refreshStyles()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateStyle(form: StyleUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Styles/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateStyleId(form.styleId)
          this.#flowService.refreshStyles()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteStyle(styleId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Styles/Delete/${styleId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateStyleId(null)
          this.#flowService.refreshStyles()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}