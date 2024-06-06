import { Component, OnDestroy, inject } from '@angular/core';
import { AudioOldService } from '../../../core/services/audio-old.service';

export class Note
{
  name : string = ''
  freq : number = 0
  row : number = 0
  alteration : boolean = false
  extension : boolean = false
  doubleUp : boolean | undefined = undefined
}

@Component({
  selector: 'app-trainer-notes',
  templateUrl: './trainer-notes.component.html',
  styleUrl: './trainer-notes.component.scss'
})
export class TrainerNotesComponent implements OnDestroy
{
  audioService = inject(AudioOldService)

  timer : number = 15
  intervalId : any | undefined = undefined
  run : number = 0

  gameStart : boolean = false
  gameEnd : boolean = false

  clefBass : boolean = false
  clefTreble : boolean = false
  clefAlto : boolean = false

  score : number = 0
  
  pic : boolean | undefined = false
  note : boolean = false
  randomNote : Note = new Note() 
  previousRandomNote : Note = new Note()
  userNote : Note = new Note() 
  
  message : string = 'Get Ready !'

  notes : Note[] = []
  notesREF : Note[] = 
  [
    { name: 'C', freq: 261.63, row: 1, alteration: false, extension: true, doubleUp : undefined },
    { name: 'C#', freq: 277.18, row: 1, alteration: true, extension: true, doubleUp : undefined },
    { name: 'D', freq: 293.66, row: 2, alteration: false, extension: false, doubleUp : undefined },
    { name: 'D#', freq: 311.13, row: 2, alteration: true, extension: false, doubleUp : undefined },
    { name: 'E', freq: 329.63, row: 3, alteration: false, extension: false, doubleUp : undefined },
    { name: 'F', freq: 349.23, row: 4, alteration: false, extension: false, doubleUp : undefined },
    { name: 'F#', freq: 369.99, row: 4, alteration: true, extension: false, doubleUp : undefined },
    { name: 'G', freq: 392, row: 5, alteration: false, extension: false, doubleUp : undefined },
    { name: 'G#', freq: 415.3, row: 5, alteration: true, extension: false, doubleUp : undefined },
    { name: 'A', freq: 440, row: 6, alteration: false, extension: false, doubleUp : undefined },
    { name: 'A#', freq: 466.16, row: 6, alteration: true, extension: false, doubleUp : undefined },
    { name: 'B', freq: 493.88, row: 7, alteration: false, extension: false, doubleUp : undefined },
  ]

  info : boolean = false

  ngOnDestroy() : void 
  {
    this.timerStop()
  }

  reset()
  {
    this.timerStop()
    this.timer = 15
    this.run = 0

    this.gameStart = false
    this.gameEnd = false
  
    this.clefBass = false
    this.clefTreble = false
    this.clefAlto = false
  
    this.score = 0
    
    this.pic = false  
    this.note = false
    this.randomNote = new Note() 
    this.previousRandomNote = new Note() 

    this.userNote = new Note() 
    this.message = 'Get Ready !'

    this.info = false
  }

  start()
  {
    if(this.clefBass || this.clefAlto || this.clefTreble)
    {
      this.initializeNotes()
      this.gameStart = true
      this.generateRandomNote()
      this.timerStart()
      this.message = "Let's Go !"
    }
    else
    this.message = 'You must select a clef first !'
  }

  timerStart() : void
  {
    this.intervalId = setInterval(() => 
    {
      if(this.timer > 0)
      {
        this.timer -= 1
        this.run += 1
      }
      else
      {
        this.gameEnd = true
        if(this.score > 0) this.message = 'Congratulations !'
        if(this.score <= 0) this.message = ' ... '
        this.timerStop()
      }
    }, 
    1000)
  }  
  timerStop() : void
  {
    if (this.intervalId !== undefined) 
    {
      clearInterval(this.intervalId)
      this.intervalId = undefined
    }
  }

  clefBassTrigger()
  {
    this.clefBass = true
    this.clefTreble = false
    this.clefAlto = false
  }

  clefTrebleTrigger()
  {
    this.clefBass = false
    this.clefTreble = true
    this.clefAlto = false
  }

  clefAltoTrigger()
  {
    this.clefBass = false
    this.clefTreble = false
    this.clefAlto = true
  }

  updateUserNote(note : Note)
  {
    this.userNote = note
    this.checkNote()
    this.generateRandomNote()
  }

  generateRandomNote() {
    let randomIndex = Math.floor(Math.random() * this.notes.length);
    this.randomNote = this.notes[randomIndex];
    this.previousRandomNote = this.notes[randomIndex]
    this.playNote(this.randomNote.freq);
}

  checkNote()
  {
    if(this.userNote.name === this.randomNote.name)
    {
      this.timer += 1
      this.message = 'Yeah ! Keep Going !'
      this.score += 5    
    }
    if(this.userNote.name !== this.randomNote.name)
    {
      this.timer -= 2
      this.message = 'Wrong !! It was ' + this.previousRandomNote.name + ' !!'
      this.score -= 6 
    }
  }

  playNote(freq : number)
  {
    this.audioService.playFrequencyWithEnvelope(freq, 1, 1)
  }

  initializeNotes() 
  {
    if (this.clefBass === true) 
    {
      this.notes =
      [
        { name: 'D', freq: 73.415, row: 0, alteration: false, extension: false, doubleUp: true },
        { name: 'D#', freq: 77.783, row: 0, alteration: true, extension: false, doubleUp: true },
        { name: 'E', freq: 82.408, row: 1, alteration: false, extension: true, doubleUp: undefined },
        { name: 'F', freq: 87.308, row: 2, alteration: false, extension: false, doubleUp: undefined },
        { name: 'F#', freq: 92.5, row: 2, alteration: true, extension: false, doubleUp: undefined },
        { name: 'G', freq: 98, row: 3, alteration: false, extension: false, doubleUp: undefined },
        { name: 'G#', freq: 103.825, row: 3, alteration: true, extension: false, doubleUp: undefined },
        { name: 'A', freq: 110, row: 4, alteration: false, extension: false, doubleUp: undefined },
        { name: 'A#', freq: 116.54, row: 4, alteration: true, extension: false, doubleUp: undefined },
        { name: 'B', freq: 123.47, row: 5, alteration: false, extension: false, doubleUp: undefined },       
        { name: 'C', freq: 130.815, row: 6, alteration: false, extension: false, doubleUp : undefined },
        { name: 'C#', freq: 138.59, row: 6, alteration: true, extension: false, doubleUp : undefined },
        { name: 'D', freq: 146.83, row: 7, alteration: false, extension: false, doubleUp : undefined },
        { name: 'D#', freq: 155.565, row: 7, alteration: true, extension: false, doubleUp : undefined },
        { name: 'E', freq: 164.815, row: 8, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F', freq: 174.615, row: 9, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F#', freq: 184.995, row: 9, alteration: true, extension: false, doubleUp : undefined },
        { name: 'G', freq: 196, row: 10, alteration: false, extension: false, doubleUp : undefined },
        { name: 'G#', freq: 207.65, row: 10, alteration: true, extension: false, doubleUp : undefined },
        { name: 'A', freq: 220, row: 11, alteration: false, extension: false, doubleUp : undefined },
        { name: 'A#', freq: 233.08, row: 11, alteration: true, extension: false, doubleUp : undefined },
        { name: 'B', freq: 246.94, row: 12, alteration: false, extension: false, doubleUp : undefined }
      ]
    }
    if (this.clefAlto === true) 
    {
      this.notes =
      [
        { name: 'C', freq: 130.815, row: 0, alteration: false, extension: false, doubleUp : true },
        { name: 'C#', freq: 138.59, row: 0, alteration: true, extension: false, doubleUp : true },
        { name: 'D', freq: 146.83, row: 1, alteration: false, extension: true, doubleUp : undefined },
        { name: 'D#', freq: 155.565, row: 1, alteration: true, extension: true, doubleUp : undefined },
        { name: 'E', freq: 164.815, row: 2, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F', freq: 174.615, row: 3, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F#', freq: 184.995, row: 3, alteration: true, extension: false, doubleUp : undefined },
        { name: 'G', freq: 196, row: 4, alteration: false, extension: false, doubleUp : undefined },
        { name: 'G#', freq: 207.65, row: 4, alteration: true, extension: false, doubleUp : undefined },
        { name: 'A', freq: 220, row: 5, alteration: false, extension: false, doubleUp : undefined },
        { name: 'A#', freq: 233.08, row: 5, alteration: true, extension: false, doubleUp : undefined },
        { name: 'B', freq: 246.94, row: 6, alteration: false, extension: false, doubleUp: undefined },
        { name: 'C', freq: 261.63, row: 7, alteration: false, extension: false, doubleUp : undefined },
        { name: 'C#', freq: 277.18, row: 7, alteration: true, extension: false, doubleUp : undefined },
        { name: 'D', freq: 293.66, row: 8, alteration: false, extension: false, doubleUp : undefined },
        { name: 'D#', freq: 311.13, row: 8, alteration: true, extension: false, doubleUp : undefined },
        { name: 'E', freq: 329.63, row: 9, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F', freq: 349.23, row: 10, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F#', freq: 369.99, row: 10, alteration: true, extension: false, doubleUp : undefined },
        { name: 'G', freq: 392, row: 11, alteration: false, extension: false, doubleUp : undefined },
        { name: 'G#', freq: 415.3, row: 11, alteration: true, extension: false, doubleUp : undefined },
        { name: 'A', freq: 440, row: 12, alteration: false, extension: false, doubleUp : undefined },
        { name: 'A#', freq: 466.16, row: 12, alteration: true, extension: false, doubleUp : undefined },
        // { name: 'B', freq: 493.88, row: 13, alteration: false, extension: false, doubleUp : undefined },
      ]
    }
    if (this.clefTreble === true) 
    {
      this.notes =
      [
        // { name: 'A', freq: 220, row: -1, alteration: false, extension: true, doubleUp: false },
        // { name: 'A#', freq: 233.08, row: -1, alteration: true, extension: true, doubleUp: false },
        { name: 'B', freq: 246.94, row: 0, alteration: false, extension: false, doubleUp: true },
        { name: 'C', freq: 261.63, row: 1, alteration: false, extension: true, doubleUp : undefined },
        { name: 'C#', freq: 277.18, row: 1, alteration: true, extension: true, doubleUp : undefined },
        { name: 'D', freq: 293.66, row: 2, alteration: false, extension: false, doubleUp : undefined },
        { name: 'D#', freq: 311.13, row: 2, alteration: true, extension: false, doubleUp : undefined },
        { name: 'E', freq: 329.63, row: 3, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F', freq: 349.23, row: 4, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F#', freq: 369.99, row: 4, alteration: true, extension: false, doubleUp : undefined },
        { name: 'G', freq: 392, row: 5, alteration: false, extension: false, doubleUp : undefined },
        { name: 'G#', freq: 415.3, row: 5, alteration: true, extension: false, doubleUp : undefined },
        { name: 'A', freq: 440, row: 6, alteration: false, extension: false, doubleUp : undefined },
        { name: 'A#', freq: 466.16, row: 6, alteration: true, extension: false, doubleUp : undefined },
        { name: 'B', freq: 493.88, row: 7, alteration: false, extension: false, doubleUp : undefined },
        { name: 'C', freq: 523.26, row: 8, alteration: false, extension: false, doubleUp : undefined },
        { name: 'C#', freq: 554.36, row: 8, alteration: true, extension: false, doubleUp : undefined },
        { name: 'D', freq: 587.32, row: 9, alteration: false, extension: false, doubleUp : undefined },
        { name: 'D#', freq: 622.26, row: 9, alteration: true, extension: false, doubleUp : undefined },
        { name: 'E', freq: 659.26, row: 10, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F', freq: 698.46, row: 11, alteration: false, extension: false, doubleUp : undefined },
        { name: 'F#', freq: 739.98, row: 11, alteration: true, extension: false, doubleUp : undefined },
        { name: 'G', freq: 784, row: 12, alteration: false, extension: false, doubleUp : undefined },
        { name: 'G#', freq: 830.6, row: 12, alteration: true, extension: false, doubleUp : undefined },
        // { name: 'A', freq: 880, row: 13, alteration: false, extension: true, doubleUp : undefined },
        // { name: 'A#', freq: 932.32, row: 13, alteration: true, extension: true, doubleUp : undefined },
        // { name: 'B', freq: 987.76, row: 14, alteration: false, extension: false, doubleUp : true }
      ]
    }
  }

  infoTrigger()
  {
    this.info = !this.info
  }
}