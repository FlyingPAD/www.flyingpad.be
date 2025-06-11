import { Component, Input, Output, EventEmitter, ChangeDetectionStrategy, AfterViewInit, inject } from '@angular/core';
import { NotificationData } from '../../interfaces/notification-data';
import { ConfettiService } from '../../services/user-interface/confetti.service';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class NotificationComponent implements AfterViewInit {
  #confettiService = inject(ConfettiService)

  @Input() data!: NotificationData
  @Output() close = new EventEmitter<void>()

  public hasLaunched = false
  public isLeaving = false

  ngAfterViewInit(): void {
    if (!this.hasLaunched) {
      this.hasLaunched = true
      this.#confettiService.launchConfetti()
    }
  }

  public onClick(): void {
    this.isLeaving = true
    setTimeout(() => this.close.emit(), 300)
  }
}