import { Interval } from "./interval";
import { Note } from "./note";

export class Scale
{
  id :          number     = 1
  nature :      string     = 'Major' 
  natureFr :    string     = 'Majeur'
  mode :        string     = 'ionian'
  modeFr :      string     = 'ionien'
  intervals :   Interval[] = 
  [
    new Interval(2),
    new Interval(2),
    new Interval(1),
    new Interval(2),
    new Interval(2),
    new Interval(2),
    new Interval(1),
    
  ]
  notes :       Note[] = 
  [

  ]

  constructor()
  {

  }
}