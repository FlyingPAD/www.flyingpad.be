export class Interval
{
  steps :         number = 0
  name :          string = ''
  notation :      string = ''  
  nameFr :        string = ''
  notationFr :    string = ''

  constructor(steps : number)
  {
    this.steps = steps
  }

  intervalsREF = 
  [
    { steps :  1, name : 'minor Second',     notation : 'm2', nameFr : 'Seconde mineure',  notationFr : '' },
    { steps :  2, name : 'Major Second',     notation : 'M2', nameFr : 'Seconde Majeure',  notationFr : '' },
    { steps :  3, name : 'minor Third',      notation : 'm3', nameFr : 'Tierce mineure',   notationFr : '' },
    { steps :  4, name : 'Major Third',      notation : 'M3', nameFr : 'Tierce Majeure',   notationFr : '' },
    { steps :  5, name : 'Fourth',           notation : '4',  nameFr : 'Quarte',           notationFr : '' },
    { steps :  6, name : 'Diminished Fifth', notation : 'b5', nameFr : 'Quinte diminuée',  notationFr : '' },
    { steps :  7, name : 'Fifth',            notation : '5',  nameFr : 'Quinte',           notationFr : '' },
    { steps :  8, name : 'Augmented Fifth',  notation : 'b6', nameFr : 'Quinte augmentée', notationFr : '' },
    { steps :  9, name : 'Sixth',            notation : '6',  nameFr : 'Sixte',            notationFr : '' },
    { steps : 10, name : 'minor Seventh',    notation : 'b7', nameFr : 'Septième mineure', notationFr : '' },
    { steps : 11, name : 'Major Seventh',    notation : 'M7', nameFr : 'Septième Majeure', notationFr : '' },
    { steps : 12, name : 'Octave',           notation : '8',  nameFr : 'Octave',           notationFr : '' },
    { steps : 13, name : 'minor ninth',      notation : 'b9', nameFr : 'Neuvième mineure', notationFr : '' },
    { steps : 14, name : 'Major Ninth',      notation : '#9', nameFr : 'Neuvième Majeure', notationFr : '' },
    { steps : 15, name : 'minor Third',      notation : '#9', nameFr : 'Tièrce',           notationFr : '' },
    { steps : 16, name : 'Major Ninth',      notation : '#9', nameFr : 'Onzième mineure',  notationFr : '' },
    { steps : 17, name : 'Major Ninth',      notation : '#9', nameFr : 'Onzième Majeure',  notationFr : '' },
    { steps : 18, name : 'Major Ninth',      notation : '#9', nameFr : 'Neuvième Majeure', notationFr : '' }
  ]
}