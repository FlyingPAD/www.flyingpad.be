import { Component, ElementRef, HostListener, ViewChild } from '@angular/core';

@Component({
  selector: 'app-chord-wheel',
  templateUrl: './chord-wheel.component.html',
  styleUrl: './chord-wheel.component.scss'
})
export class ChordWheelComponent {
  @ViewChild('wheel', { static: false }) wheel!: ElementRef;

  currentAngle: number = 0
  random: number = 1
  currentPosition: number = 1

  keyFR: string = "Do"
  keyFRAlt: string = ""
  keyEN: string = "C"
  keyENAlt: string = ""

  private checkPosition(currentAngle: number): void {
    this.currentPosition = ((currentAngle % 360) + 360) % 360 / 30 + 1
  }

  private switchKey(position: number) {
    switch (position) {
      case 1:
        this.keyEN = "C"
        this.keyENAlt = ""
        this.keyFR = "Do"
        this.keyFRAlt = ""
        break;
      case 12:
        this.keyEN = "G"
        this.keyENAlt = ""
        this.keyFR = "Sol"
        this.keyFRAlt = ""
        break;
      case 11:
        this.keyEN = "D"
        this.keyENAlt = ""
        this.keyFR = "Ré"
        this.keyFRAlt = ""
        break;
      case 10:
        this.keyEN = "A"
        this.keyENAlt = ""
        this.keyFR = "La"
        this.keyFRAlt = ""
        break;
      case 9:
        this.keyEN = "E"
        this.keyENAlt = ""
        this.keyFR = "Mi"
        this.keyFRAlt = ""
        break;
      case 8:
        this.keyEN = "B"
        this.keyENAlt = ""
        this.keyFR = "Si"
        this.keyFRAlt = ""
        break;
      case 7:
        this.keyEN = "F#"
        this.keyENAlt = "Gb"
        this.keyFR = "Fa dièse"
        this.keyFRAlt = "Sol bémol"
        break;
      case 6:
        this.keyEN = "C#"
        this.keyENAlt = "Db"
        this.keyFR = "Do dièse"
        this.keyFRAlt = "Ré bémol"
        break;
      case 5:
        this.keyEN = "G#"
        this.keyENAlt = "Ab"
        this.keyFR = "Sol dièse"
        this.keyFRAlt = "La bémol"
        break;
      case 4:
        this.keyEN = "Eb"
        this.keyENAlt = ""
        this.keyFR = "Mi bémol"
        this.keyFRAlt = ""
        break;
      case 3:
        this.keyEN = "Bb"
        this.keyENAlt = ""
        this.keyFR = "Si bémol"
        this.keyFRAlt = ""
        break;
      case 2:
        this.keyEN = "F"
        this.keyENAlt = ""
        this.keyFR = "Fa"
        this.keyFRAlt = ""
        break;
    }
  }

  public rotateImage(degrees: number): void {
    this.currentAngle += degrees
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`;
    this.checkPosition(this.currentAngle)
    this.switchKey(this.currentPosition)
  }

  public randomPosition(): void {
    this.random = Math.floor(Math.random() * 11) + 1

    this.currentAngle = this.random * 30
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`;
    this.checkPosition(this.currentAngle)
    this.switchKey(this.currentPosition)
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case '0':
        this.randomPosition()
        break
      case 'ArrowLeft':
        this.rotateImage(-30)
        break
      case 'ArrowRight':
        this.rotateImage(30)
        break
    }
  }
}