import { Component, EventEmitter, HostListener, inject, Input, Output } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-bottom-bar',
  templateUrl: './bottom-bar.component.html',
  styleUrl: './bottom-bar.component.scss'
})
export class BottomBarComponent {
  #userService = inject(UserService)

  @Input() entityName: string | undefined = undefined
  @Input() moodsLength: number | undefined = undefined
  @Input() infoTriggerIsActive: boolean | undefined = undefined
  @Input() moodsGalleryType: string = 'all'
  @Input() currentIndex: number = 0
  @Input() moodType: number = 0
  @Input() diaporamaIsActive: boolean = false

  @Output() dialog = new EventEmitter<void>()
  @Output() openMoodInNewTab = new EventEmitter<void>()
  @Output() randomMood = new EventEmitter<void>()
  @Output() back = new EventEmitter<void>()
  @Output() getIndex = new EventEmitter<string>()
  @Output() diaporamaStart = new EventEmitter<boolean>()
  @Output() diaporamaStop = new EventEmitter<void>()
  @Output() leftCard = new EventEmitter<void>()
  @Output() isFocused = new EventEmitter<boolean>(false)
  @Output() edition = new EventEmitter<void>()
  @Output() showDetails = new EventEmitter<void>()
  @Output() showMultiTag = new EventEmitter<void>()
  @Output() triggerSaveMood = new EventEmitter<void>()

  public user = this.#userService.user
  public topButtonIsActive: boolean = false
  public focusIsActive: boolean = false

  public handleDialog(): void { this.dialog.emit() }
  public handleOpenMoodInNewTab(): void { this.openMoodInNewTab.emit() }
  public handleRandomMood(): void { this.randomMood.emit() }
  public handleBackToGallery(): void { this.back.emit() }
  public handleEditButton(): void { this.edition.emit() }
  public handleGetIndex(direction: string): void { this.getIndex.emit(direction) }
  public handleDiaporamaStart(isRandom: boolean): void { this.diaporamaStart.emit(isRandom) }
  public handleDiaporamaStop(): void { this.diaporamaStop.emit() }
  public handleLeftCard(): void { this.leftCard.emit() }
  public handleToggleFocus(): void { this.isFocused.emit(this.focusIsActive ? false : true); this.focusIsActive = this.focusIsActive ? false : true }
  public handleShowDetails(): void { this.showDetails.emit() }
  public handleTriggerSaveMood(): void { this.triggerSaveMood.emit() }
  public handleShowMultiTag(): void { this.showMultiTag.emit() }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll(): void {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }
}