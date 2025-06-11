import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class OverlayConfigService {
  public readonly notificationDuration = 3000
  public readonly notificationSpacing = 300
}