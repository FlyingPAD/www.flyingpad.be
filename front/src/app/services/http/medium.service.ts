import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { tap } from 'rxjs';
import { environment } from '../../../environments/environment';
import { BaseResponse } from '../../interfaces/base-response';
import { MediumCreateForm } from '../../interfaces/forms-create';
import { CreateMediumResponse } from '../../interfaces/responses-create';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { MediumUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class MediumService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createMedium(form: MediumCreateForm) {
    return this.#http.post<CreateMediumResponse>(`${this.#url}Media/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateMediumId(response.mediumId)
          this.#flowService.refreshMedia()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateMedium(form: MediumUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Media/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateMediumId(form.mediumId)
          this.#flowService.refreshMedia()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteMedium(mediumId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Media/Delete/${mediumId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateMediumId(null)
          this.#flowService.refreshMedia()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}