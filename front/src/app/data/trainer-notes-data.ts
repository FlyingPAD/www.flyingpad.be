import { NoteTrainer } from '../interfaces/music-tools/note-trainer';

export const notesREF: NoteTrainer[] = [
  { name: 'C',  freq: 261.63, row: 1, alteration: false, extension: true,  doubleUp: undefined },
  { name: 'C#', freq: 277.18, row: 1, alteration: true,  extension: true,  doubleUp: undefined },
  { name: 'D',  freq: 293.66, row: 2, alteration: false, extension: false, doubleUp: undefined },
  { name: 'D#', freq: 311.13, row: 2, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'E',  freq: 329.63, row: 3, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 349.23, row: 4, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 369.99, row: 4, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 392,    row: 5, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 415.3,  row: 5, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq: 440,    row: 6, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 466.16,row: 6, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'B',  freq: 493.88,row: 7, alteration: false, extension: false, doubleUp: undefined }
];

/** Notes pour la clef de basse */
export const bassNotes: NoteTrainer[] = [
  { name: 'D',  freq:  73.415, row:  0, alteration: false, extension: false, doubleUp: true },
  { name: 'D#', freq:  77.783, row:  0, alteration: true,  extension: false, doubleUp: true },
  { name: 'E',  freq:  82.408, row:  1, alteration: false, extension: true,  doubleUp: undefined },
  { name: 'F',  freq:  87.308, row:  2, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq:  92.5,   row:  2, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq:   98,    row:  3, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 103.825, row:  3, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq:  110,    row:  4, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 116.54,  row:  4, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'B',  freq: 123.47,  row:  5, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C',  freq: 130.815, row:  6, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C#', freq: 138.59,  row:  6, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'D',  freq: 146.83,  row:  7, alteration: false, extension: false, doubleUp: undefined },
  { name: 'D#', freq: 155.565, row:  7, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'E',  freq: 164.815, row:  8, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 174.615, row:  9, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 184.995, row:  9, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 196,     row: 10, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 207.65,  row: 10, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq: 220,     row: 11, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 233.08,  row: 11, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'B',  freq: 246.94,  row: 12, alteration: false, extension: false, doubleUp: undefined }
];

/** Notes pour la clef alto */
export const altoNotes: NoteTrainer[] = [
  { name: 'C',  freq: 130.815, row:  0, alteration: false, extension: false, doubleUp: true },
  { name: 'C#', freq: 138.59,  row:  0, alteration: true,  extension: false, doubleUp: true },
  { name: 'D',  freq: 146.83,  row:  1, alteration: false, extension: true,  doubleUp: undefined },
  { name: 'D#', freq: 155.565, row:  1, alteration: true,  extension: true,  doubleUp: undefined },
  { name: 'E',  freq: 164.815, row:  2, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 174.615, row:  3, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 184.995, row:  3, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 196,     row:  4, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 207.65,  row:  4, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq: 220,     row:  5, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 233.08,  row:  5, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'B',  freq: 246.94,  row:  6, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C',  freq: 261.63,  row:  7, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C#', freq: 277.18,  row:  7, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'D',  freq: 293.66,  row:  8, alteration: false, extension: false, doubleUp: undefined },
  { name: 'D#', freq: 311.13,  row:  8, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'E',  freq: 329.63,  row:  9, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 349.23,  row: 10, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 369.99,  row: 10, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 392,     row: 11, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 415.3,   row: 11, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq: 440,     row: 12, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 466.16,  row: 12, alteration: true,  extension: false, doubleUp: undefined }
  // { name: 'B',  freq: 493.88, row: 13, alteration: false, extension: false, doubleUp: undefined },
];

/** Notes pour la clef de sol (treble) */
export const trebleNotes: NoteTrainer[] = [
  { name: 'B',  freq: 246.94, row:  0, alteration: false, extension: false, doubleUp: true },
  { name: 'C',  freq: 261.63, row:  1, alteration: false, extension: true,  doubleUp: undefined },
  { name: 'C#', freq: 277.18, row:  1, alteration: true,  extension: true,  doubleUp: undefined },
  { name: 'D',  freq: 293.66, row:  2, alteration: false, extension: false, doubleUp: undefined },
  { name: 'D#', freq: 311.13, row:  2, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'E',  freq: 329.63, row:  3, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 349.23, row:  4, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 369.99, row:  4, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 392,     row:  5, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 415.3,  row:  5, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'A',  freq: 440,    row:  6, alteration: false, extension: false, doubleUp: undefined },
  { name: 'A#', freq: 466.16,row:  6, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'B',  freq: 493.88,row:  7, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C',  freq: 523.26,row:  8, alteration: false, extension: false, doubleUp: undefined },
  { name: 'C#', freq: 554.36,row:  8, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'D',  freq: 587.32,row:  9, alteration: false, extension: false, doubleUp: undefined },
  { name: 'D#', freq: 622.26,row:  9, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'E',  freq: 659.26,row: 10, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F',  freq: 698.46,row: 11, alteration: false, extension: false, doubleUp: undefined },
  { name: 'F#', freq: 739.98,row: 11, alteration: true,  extension: false, doubleUp: undefined },
  { name: 'G',  freq: 784,   row: 12, alteration: false, extension: false, doubleUp: undefined },
  { name: 'G#', freq: 830.6, row: 12, alteration: true,  extension: false, doubleUp: undefined }
  // { name: 'A',  freq: 880,   row: 13, alteration: false, extension: true,  doubleUp: undefined },
  // { name: 'A#', freq: 932.32,row: 13, alteration: true,  extension: true,  doubleUp: undefined },
  // { name: 'B',  freq: 987.76,row: 14, alteration: false, extension: false, doubleUp: undefined }
];

/** Utility pour récupérer la bonne liste selon la clef */
export function getNotesForClef(clef: 'bass' | 'alto' | 'treble'): NoteTrainer[] {
  switch (clef) {
    case 'bass':   return bassNotes;
    case 'alto':   return altoNotes;
    case 'treble': return trebleNotes;
    default:       return [];
  }
}