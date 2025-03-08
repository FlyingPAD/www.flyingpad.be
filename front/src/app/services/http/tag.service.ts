import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { tap } from 'rxjs';
import { environment } from '../../../environments/environment';
import { BaseResponse } from '../../interfaces/base-response';
import { TagCreateForm } from '../../interfaces/forms-create';
import { CreateTagResponse } from '../../interfaces/responses-create';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { TagUpdateForm } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class TagService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createTag(form: TagCreateForm) {
    return this.#http.post<CreateTagResponse>(`${this.#url}Tags/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagId(response.tagId)
          this.#flowService.updateTagCategoryId(form.tagCategoryId)
          this.#flowService.refreshTags()
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateTag(form: TagUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Tags/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagId(form.tagId)
          this.#flowService.updateTagCategoryId(form.tagCategoryId)
          this.#flowService.refreshTags()
          this.#flowService.refreshTagCategories()
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public deleteTag(tagId: number, tagCategoryId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Tags/Delete/${tagId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateTagId(null)
          this.#flowService.refreshTags()
          this.#flowService.updateTagCategoryId(tagCategoryId)
          this.#flowService.refreshTagCategories()
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}