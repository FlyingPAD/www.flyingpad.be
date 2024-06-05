import { Component } from '@angular/core';

@Component({
  selector: 'app-trainer-notes',
  templateUrl: './trainer-notes.component.html',
  styleUrl: './trainer-notes.component.scss'
})
export class TrainerNotesComponent 
{
  gameConfig : boolean = false
  gameStart : boolean = false
  gameEnd : boolean = false

  clefBass : boolean = false
  clefTreble : boolean = false
  play : boolean = false
  note : boolean = false

  notes : string[] = ['C', 'C#', 'D', 'D#', 'E', 'F', 'F#', 'G', 'G#', 'A', 'A#', 'B']

  userNote : string = ''
  randomNote : string = ''

  result : string = ''

  clefBassTrigger()
  {
    this.clefBass = true
    this.clefTreble = false
  }

  clefTrebleTrigger()
  {
    this.clefBass = false
    this.clefTreble = true
  }

  start()
  {
    this.gameConfig = false
    this.gameStart = true
    this.generateRandomNote()
  }

  configTrigger()
  {
    this.gameConfig = !this.gameConfig
  }

  updateUserNote( note : string)
  {
    this.userNote = note
    this.checkNote()
    this.generateRandomNote()
  }

  generateRandomNote() 
  {
    const randomIndex = Math.floor(Math.random() * this.notes.length)
    this.randomNote = this.notes[randomIndex]
  }

  checkNote()
  {
    if(this.userNote === this.randomNote)
    {
      this.result = 'You Rule !'
    }
    if(this.userNote !== this.randomNote)
    {
      this.result = 'You Suck !'
    }
  }
}
