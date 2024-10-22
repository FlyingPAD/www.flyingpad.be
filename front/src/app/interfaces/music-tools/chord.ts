import { Interval } from "../../models/music-tools/interval";
import { Note } from "./note";

export interface Chord {
  id: number
  name: string
  intervals: Interval[]
  notes: Note[]
}