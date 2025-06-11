import { inject, Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { concatMap, delay } from 'rxjs/operators';
import { OverlayService } from './overlay.service';
import { OverlayConfigService } from './overlay-config.service';
import { NotificationComponent } from '../../components/notification/notification.component';
import { NewAchievement } from '../../interfaces/achievement';
import { NotificationData } from '../../interfaces/notification-data';

@Injectable({ providedIn: 'root' })
export class AchievementNotifierService {
  #overlayService = inject(OverlayService)
  #overlayConfig = inject(OverlayConfigService)

  #queue$ = new Subject<NewAchievement>()

  constructor() {
    this.#queue$.pipe(concatMap(achievement => this.show(achievement))).subscribe()
  }

  private show(ach: NewAchievement) {
    const data: NotificationData = {
      iconSize: '80px',
      iconOuterColor: ach.unlockedAt ? 'gold' : 'darkgrey',
      title: `Succès débloqué !`,
      message: ach.title,
      subMessage: `+ ${ach.xpReward} XP`
    }
    const handle = this.#overlayService.open(NotificationComponent, { data })
    return handle.closed$.pipe(delay(this.#overlayConfig.notificationSpacing))
  }

  public notify(achievement: NewAchievement) {
    this.#queue$.next(achievement)
  }
}