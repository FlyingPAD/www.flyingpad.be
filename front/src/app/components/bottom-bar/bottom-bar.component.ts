import { Component, EventEmitter, HostListener, inject, Input, Output } from '@angular/core';
import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-bottom-bar',
  templateUrl: './bottom-bar.component.html',
  styleUrl: './bottom-bar.component.scss'
})
export class BottomBarComponent {
  userService = inject(UserService)

  @Input() entityName : string | undefined = undefined
  @Input() moodsLength : number | undefined = undefined
  @Input() infoTriggerIsActive : boolean | undefined = undefined
  @Input() moodsGalleryType : string = 'all'
  @Input() currentIndex : number = 0
  @Input() moodType : number = 0
  
  @Output() topButton = new EventEmitter<void>()
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
  
  topButtonIsActive : boolean = false
  diaporamaIsActive : boolean = false
  leftCardIsActive : boolean = false
  focusIsActive : boolean = false

  handleTopButton(): void {this.topButton.emit()}
  handleDialog(): void {this.dialog.emit()}
  handleOpenMoodInNewTab(): void {this.openMoodInNewTab.emit()}
  handleRandomMood(): void {this.randomMood.emit()}
  handleBackToGallery(): void {this.back.emit()}
  handleEditButton(): void {this.edition.emit()}
  handleGetIndex(direction : string): void {this.getIndex.emit(direction)}
  handleDiaporamaStart(isRandom : boolean): void {this.diaporamaStart.emit(isRandom); this.diaporamaIsActive = true}
  handleDiaporamaStop(): void {this.diaporamaStop.emit(); this.diaporamaIsActive = false}
  handleLeftCard(): void {this.leftCard.emit()}
  handleToggleFocus(): void {this.isFocused.emit(this.focusIsActive ? false : true); this.focusIsActive = this.focusIsActive ? false : true}
  handleShowDetails(): void {this.showDetails.emit()}

  @HostListener('window:scroll', ['$event'])
  onWindowScroll(): void {
    const threshold = 100
    const currentScrollPosition = window.scrollY || document.documentElement.scrollTop || document.body.scrollTop || 0
    this.topButtonIsActive = currentScrollPosition > threshold
  }
}