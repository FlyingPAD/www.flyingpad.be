import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { FranchiseCreateForm } from '../../interfaces/forms-create';
import { CreateFranchiseResponse } from '../../interfaces/responses-create';
import { FranchiseUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class FranchiseService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createFranchise(form: FranchiseCreateForm) {
    return this.#http.post<CreateFranchiseResponse>(`${this.#url}Franchises/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateFranchiseId(response.franchiseId)
          this.#flowService.refreshFranchises()
          this.#flowService.updateMediumId(form.mediaIds[0])
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateFranchise(form: FranchiseUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Franchises/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateFranchiseId(form.franchiseId)
          this.#flowService.refreshFranchises()
          this.#flowService.updateMediumId(form.mediaIds[0])
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteFranchise(franchiseId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Franchises/Delete/${franchiseId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateFranchiseId(null)
          this.#flowService.refreshFranchises()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}