import { Component, inject } from '@angular/core';
import { AudioOldService } from '../../../core/services/audio-old.service';


export class Note
{
  name : string = ''
  freq : number = 0
}

@Component({
  selector: 'app-trainer-notes',
  templateUrl: './trainer-notes.component.html',
  styleUrl: './trainer-notes.component.scss'
})
export class TrainerNotesComponent 
{
  audioService = inject(AudioOldService)
  gameConfig : boolean = false
  gameStart : boolean = false
  gameEnd : boolean = false

  clefBass : boolean = false
  clefTreble : boolean = false
  pic : boolean | undefined = false
  note : boolean = false

  notes : Note[] = 
  [
    {name : 'C', freq : 261.63 },
    {name : 'C#', freq : 277.18 },
    {name : 'D', freq : 293.66 },
    {name : 'D#', freq : 311.13, },
    {name : 'E', freq : 329.63 },
    {name : 'F', freq : 349.23 },
    {name : 'F#', freq : 369.99 },
    {name : 'G', freq : 392 },
    {name : 'G#', freq : 415.3 },
    {name : 'A', freq : 440 },
    {name : 'A#', freq : 466.16 },
    {name : 'B', freq : 493.88 },

  ]

  userNote : string = ''
  randomNote : string = ''
  previousRandomNote : string = ''

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
    const selectedNote = this.notes[randomIndex]
    this.randomNote = selectedNote.name
    this.previousRandomNote = selectedNote.name
    this.playNote(selectedNote.freq)
  }
  checkNote()
  {
    if(this.userNote === this.randomNote)
    {
      this.result = 'You Rule !'
    }
    if(this.userNote !== this.randomNote)
    {
      this.result = 'You Suck ... It was ' + this.previousRandomNote
    }
  }

  playNote(freq : number)
  {
    this.audioService.playFrequencyWithEnvelope(freq, 1, 1)
  }
}
