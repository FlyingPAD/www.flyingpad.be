import { Component, ElementRef, HostListener, ViewChild } from '@angular/core';
import { WheelKey } from '../../../models/wheel-key';

@Component({
  selector: 'app-circle-of-fifths',
  templateUrl: './circle-of-fifths.component.html',
  styleUrls: ['./circle-of-fifths.component.scss']
})
export class CircleOfFifthsComponent {
  @ViewChild('wheel', { static: false }) wheel!: ElementRef

  private currentAngle: number = 0

  public keys: WheelKey[] = [
    { name: 'C', enharmony: '', enharmonyFr: '', nameFr: 'Do', position: 0 },
    { name: 'G', enharmony: '', enharmonyFr: '', nameFr: 'Sol', position: 30 },
    { name: 'D', enharmony: '', enharmonyFr: '', nameFr: 'Ré', position: 60 },
    { name: 'A', enharmony: '', enharmonyFr: '', nameFr: 'La', position: 90 },
    { name: 'E', enharmony: '', enharmonyFr: '', nameFr: 'Mi', position: 120 },
    { name: 'B', enharmony: '', enharmonyFr: '', nameFr: 'Si', position: 150 },
    { name: 'F #', enharmony: 'G b', enharmonyFr: 'Sol b', nameFr: 'Fa #', position: 180 },
    { name: 'C #', enharmony: 'D b', enharmonyFr: 'Ré b', nameFr: 'Do #', position: 210 },
    { name: 'G #', enharmony: 'A b', enharmonyFr: 'La b', nameFr: 'Sol #', position: 240 },
    { name: 'D #', enharmony: 'E b', enharmonyFr: 'Mi b', nameFr: 'Ré #', position: 270 },
    { name: 'A #', enharmony: 'B b', enharmonyFr: 'Si b', nameFr: 'La #', position: 300 },
    { name: 'F', enharmony: '', enharmonyFr: '', nameFr: 'Fa', position: 330 }
  ]

  private rotateWheelTo(targetAngle: number): void {
    const angleDiff = (targetAngle - this.currentAngle % 360 + 360) % 360
    this.currentAngle += (angleDiff > 180) ? angleDiff - 360 : angleDiff
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  }

  public rotateToRight(): void {
    this.currentAngle -= 30
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  }

  public rotateToLeft(): void {
    this.currentAngle += 30
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  }

  public randomPosition(): void {
    const randomKeyIndex = Math.floor(Math.random() * this.keys.length)
    const targetAngle = this.keys[randomKeyIndex].position
    this.rotateWheelTo(targetAngle)
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.key) {
      case '0':
        this.randomPosition()
        break
      case 'ArrowLeft':
        this.rotateToLeft()
        break
      case 'ArrowRight':
        this.rotateToRight()
        break
    }
  }
}