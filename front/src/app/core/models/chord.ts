import { Interval } from "./interval";
import { Note } from "./note";

export interface Chord
{
  id :          number;
  name :        string;
  intervals :   Interval[];
  notes :       Note[];
}