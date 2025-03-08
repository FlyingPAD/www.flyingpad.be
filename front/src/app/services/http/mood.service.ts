import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { take, tap } from 'rxjs';
import { environment } from '../../../environments/environment';
import { BaseResponse } from '../../interfaces/base-response';
import { FlowService } from './flow.service';
import { NotificationService } from '../notification.service';
import { MoodCreateForm } from '../../interfaces/forms-create';
import { ImageForm, CreateMoodImageResponse } from '../../interfaces/mood-image';
import { VideoForm, CreateMoodVideoResponse } from '../../interfaces/mood-video';
import { CreateMoodResponse } from '../../interfaces/responses-create';
import { MoodUpdateForm, MoodScoreUpdate } from '../../interfaces/forms-update';

@Injectable({
  providedIn: 'root'
})
export class MoodService {
  #http = inject(HttpClient)
  #flowService = inject(FlowService)
  #notificationService = inject(NotificationService)
  #url: string = environment.apiBaseUrl + '/api/V1/'

  public createMood(form: MoodCreateForm) {
    return this.#http.post<CreateMoodResponse>(`${this.#url}Moods/Create`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#flowService.refreshMoods()
          this.#flowService.updateMoodId(response.moodId)
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public createImage(form: ImageForm) {
    return this.#http.post<CreateMoodImageResponse>(`${this.#url}Moods/CreateMoodImage`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public createVideo(form: VideoForm) {
    return this.#http.post<CreateMoodVideoResponse>(`${this.#url}Moods/CreateMoodVideo`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#flowService.refreshMoods()
          this.#flowService.updateMoodId(response.moodId)
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateMood(form: MoodUpdateForm) {
    return this.#http.put<BaseResponse>(`${this.#url}Moods/Update`, form).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public updateMoodScore(form: MoodScoreUpdate): void {
    this.#http.put<BaseResponse>(`${this.#url}Moods/UpdateScore`, form).pipe(
      take(1),
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.refreshMoods()
          this.#flowService.updateMoodId(form.moodId)
        }
      }),
    ).subscribe()
  }

  public deleteMood(moodId: number) {
    return this.#http.delete<BaseResponse>(`${this.#url}Moods/Delete/${moodId}`).pipe(
      tap(response => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#flowService.updateMoodId(null)
          this.#flowService.refreshMoods()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}