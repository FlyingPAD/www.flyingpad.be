import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { TagCategoryCreateForm } from '../../interfaces/forms-create';
import { CreateTagCategoryResponse } from '../../interfaces/responses-create';
import { TagCategoryUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})

export class TagCategoryService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createTagCategory(form: TagCategoryCreateForm) {
    return this.#http.post<CreateTagCategoryResponse>(`${this.#url}TagCategories/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagCategoryId(response.tagCategoryId)
          this.#flowService.refreshTagCategories()
          this.#flowService.refreshMoods()
        }
        else {
          this.#notificationService.error(response.message)
        }
      }))
  }

  public updateTagCategory(form: TagCategoryUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}TagCategories/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagCategoryId(form.tagCategoryId)
          this.#flowService.refreshTagCategories()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteTagCategory(tagCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}TagCategories/Delete/${tagCategoryId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagId(null)
          this.#flowService.updateTagCategoryId(null)
          this.#flowService.refreshTags()
          this.#flowService.refreshTagCategories()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}