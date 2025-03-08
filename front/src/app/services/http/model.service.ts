import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { NotificationService } from '../notification.service';
import { tap } from 'rxjs';
import { ModelCreateForm } from '../../interfaces/forms-create';
import { CreateModelResponse } from '../../interfaces/model';
import { FlowService } from './flow.service';
import { BaseResponse } from '../../interfaces/base-response';
import { ModelUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class ModelService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createModel(form: ModelCreateForm) {
    return this.#http.post<CreateModelResponse>(`${this.#url}Models/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateModelId(response.modelId)
          this.#flowService.refreshModels()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateModel(form: ModelUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Models/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateModelId(form.modelId)
          this.#flowService.refreshModels()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteModel(modelId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Models/Delete/${modelId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateModelId(null)
          this.#flowService.refreshModels()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}