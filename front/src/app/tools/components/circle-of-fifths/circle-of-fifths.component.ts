import { Component, ElementRef, HostListener, ViewChild } from '@angular/core';

export class WheelKey
{
  name :        string = ''
  nameFr :      string = ''
  enharmony :   string = ''
  enharmonyFr : string = ''
  position :    number = 0
}

@Component({
  selector: 'app-circle-of-fifths',
  templateUrl: './circle-of-fifths.component.html',
  styleUrl: './circle-of-fifths.component.scss'
})
export class CircleOfFifthsComponent 
{
  // Properties

  @ViewChild('wheel', {static: false}) wheel! : ElementRef;

  currentAngle :    number = 0

  keys : WheelKey[] = 
  [
    { name : 'C',   enharmony : '',    enharmonyFr : '',      nameFr : 'Do',    position : 0 },
    { name : 'G',   enharmony : '',    enharmonyFr : '',      nameFr : 'Sol',   position : 30 },
    { name : 'D',   enharmony : '',    enharmonyFr : '',      nameFr : 'Ré',    position : 60 },
    { name : 'A',   enharmony : '',    enharmonyFr : '',      nameFr : 'La',    position : 90 },
    { name : 'E',   enharmony : '',    enharmonyFr : '',      nameFr : 'Mi',    position : 120 },
    { name : 'B',   enharmony : '',    enharmonyFr : '',      nameFr : 'Si',    position : 150 },
    { name : 'F #', enharmony : 'G b', enharmonyFr : 'Sol b', nameFr : 'Fa #',  position : 180 },
    { name : 'C #', enharmony : 'D b', enharmonyFr : 'Ré b',  nameFr : 'Do #',  position : 210 },
    { name : 'G #', enharmony : 'A b', enharmonyFr : 'La b',  nameFr : 'Sol #', position : 240 },
    { name : 'D #', enharmony : 'E b', enharmonyFr : 'Mi b',  nameFr : 'Ré #',  position : 270 },
    { name : 'A #', enharmony : 'B b', enharmonyFr : 'Si b',  nameFr : 'La #',  position : 300 },
    { name : 'F',   enharmony : '',    enharmonyFr : '',      nameFr : 'Fa',    position : 330 }
  ]

  En : boolean = true
  Fr : boolean = false
  enharmony : boolean = false

  // Get Current Key :

  getCurrentKey() : WheelKey 
  {
    // Normalise l'angle pour qu'il soit toujours positif
    const normalizedAngle = (this.currentAngle % 360 + 360) % 360;
    
    // Calcule l'index en fonction de la direction de la rotation
    const currentIndex = (12 - Math.round(normalizedAngle / 30)) % 12;
    
    return this.keys[currentIndex];
  }

  // Switch Traduction :

  switchTrad()
  {
    this.En = !this.En
    this.Fr = !this.Fr
  }

  // Trigger enharmony :

  triggerEnharmony()
  {
    this.enharmony = !this.enharmony
  }

  // Select Key :

  selectKey(key: WheelKey) 
  {
    const targetAngle = key.position
    this.rotateWheelTo(targetAngle)
  }

  // Rotate Wheel To :

  rotateWheelTo(targetAngle : number) 
  {
    const angleDiff = (targetAngle - this.currentAngle % 360 + 360) % 360
    this.currentAngle += (angleDiff > 180) ? angleDiff - 360 : angleDiff
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  
  }

  // Rotate to Right :

  rotateToRight()
  {
    this.currentAngle -= 30
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  }

  // Rotate to Left :

  rotateToLeft() 
  {
    this.currentAngle += 30
    this.wheel.nativeElement.style.transform = `rotate(${this.currentAngle}deg)`
  }

  // Random Position :

  randomPosition() 
  {
    const randomKeyIndex = Math.floor(Math.random() * this.keys.length)
    const targetAngle = this.keys[randomKeyIndex].position
    this.rotateWheelTo(targetAngle)
  }

  // Keyboard Shortcuts :

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) 
  {
    switch (event.key) 
    {
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