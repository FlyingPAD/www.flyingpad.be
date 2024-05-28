import { AudioService } from "../services/audio.service";
import { KeysService } from "../services/keys.service";
import { Key } from "./key";
import { Note } from "./note";

export class KeyStation 
{
  // - Properties :

  isActive :          boolean = true
  
  stationNumber :     number  = 1
  frequencyREF :      number  = 440.00
  noteStart :         number  = 39
  noteEnd :           number  = 50
  transpose :         number  = 0
  IsFull :            boolean = true

  Key :               Key     = this.reference.KeysREF[0]

  showNotes :         boolean = true
  showNotesFr :       boolean = false
  showEnharmony :     boolean = false
  showNumbers :       boolean = true
  showFrequency :     boolean = false
  
  notes :             Note[]  = 
  [
    this.reference.notesREF[39], 
    this.reference.notesREF[40], 
    this.reference.notesREF[41], 
    this.reference.notesREF[42], 
    this.reference.notesREF[43], 
    this.reference.notesREF[44], 
    this.reference.notesREF[45], 
    this.reference.notesREF[46], 
    this.reference.notesREF[47], 
    this.reference.notesREF[48], 
    this.reference.notesREF[49], 
    this.reference.notesREF[50]
  ]

  // - Constructor :

  constructor
  (
    private audioService : AudioService, 
    private reference : KeysService
  ) { }

  // - Methods :

  switchKey( value : number )
  {
    let REF = this.Key.id - value  

    REF = (REF - 1 + this.reference.KeysREF.length) % this.reference.KeysREF.length  
    
    this.Key = this.reference.KeysREF[REF]
  }
  

  playNote( note : Note, durationInSeconds : number, volume : number )
  {
    this.audioService.playFrequencyWithEnvelope(note.frequency, durationInSeconds, volume)
  }

  addNoteLeft()
  {
    this.notes.unshift(this.reference.notesREF[this.notes[0].id - 2])
  }
  addNoteRight()
  {
    this.notes.push(this.reference.notesREF[this.notes[this.notes.length - 1].id])
  }
  

  transposition() 
  {
    if(this.transpose === 0)
    {
      this.updateNotes()
    }
    else
    {
      this.updateNotes()
    }
  }

  tuneStation(value : number)
  {
    if(this.frequencyREF <= 415.30 ) this.frequencyREF = 415.30
    else if (this.frequencyREF >= 466.16) this.frequencyREF = 466.16
    else this.frequencyREF += value
  }

  semiTonesCalculation( frequency : number, semiTonesNumber : number )
  {
    return frequency * Math.pow(2, semiTonesNumber / 12.0);
  }

  updateNotes() 
  {
    this.notes = []

    let totalNotes = this.reference.notesREF.length
  
    for (let i = this.noteStart + this.transpose; i < this.noteEnd + this.transpose + 1; i++) 
    {
      let adjustedIndex = i
  
      while (adjustedIndex < 0) 
      {
        adjustedIndex += totalNotes
      }
      while (adjustedIndex >= totalNotes) 
      {
        adjustedIndex -= totalNotes
      }
  
      this.notes.push(this.reference.notesREF[adjustedIndex])
    }
  }
}