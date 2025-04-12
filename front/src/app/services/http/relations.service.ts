import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { NotificationService } from '../notification.service';
import { tap } from 'rxjs';
import { BaseResponse } from '../../interfaces/base-response';
import { RelationsMoodTagForm, RelationsMoodArtistForm, RelationsMoodModelForm } from '../../interfaces/relations';
import { StateService } from '../custom-state/state.service';
import { StatisticsService } from './statistics.service';

@Injectable({
  providedIn: 'root'
})
export class RelationsService {
  #stateService = inject(StateService)

  #http = inject(HttpClient)
  #notificationService = inject(NotificationService)
  #statisticsService = inject(StatisticsService)

  #url: string = environment.apiBaseUrl + '/api/V1/'

  public InsertRMT(rmtForm: RelationsMoodTagForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodTag/Create', rmtForm).pipe(
      tap((response) => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(rmtForm.moodId)
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }))
  }

  public InsertRMA(rmaForm: RelationsMoodArtistForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodArtist/Create', rmaForm).pipe(
      tap((response) => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(rmaForm.moodId)
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }))
  }
  
  public InsertRMM(rmmForm: RelationsMoodModelForm) {
    return this.#http.post<BaseResponse>(this.#url + 'Relations/MoodModel/Create', rmmForm).pipe(
      tap((response) => {
        if (response.success) {
          this.#notificationService.success(response.message)
          this.#stateService.setMoodId(rmmForm.moodId)
          this.#statisticsService.refreshStatistics()
        }
        else this.#notificationService.error(response.message)
      }))
  }
}