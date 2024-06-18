import { Injectable } from '@angular/core';
import { Note } from '../models/note';
import { Chord } from '../models/chord';
import { Key } from '../models/key';
import { Scale } from '../models/scale';

@Injectable({
  providedIn: 'root'
})
export class KeysService 
{
  // Référence ISO 440 Hz

  frequencyREF : number = 440    
  
  // Pour la numérotation des notes, je me suis basé sur la convention latine ( le premier Do = Do 1 )
  
  notesREF :     Note[] = 
  [
    { id :  1, octave : 0, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 27.5,    alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id :  2, octave : 0, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 29.14,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id :  3, octave : 0, name : 'B',  enharmony : 'Cb', nameFr : 'Si',   enharmonyFr : 'Do♭',  frequency: 30.87,   alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id :  4, octave : 0, name : 'C',  enharmony : 'B#', nameFr : 'Do',   enharmonyFr : 'Si#',  frequency: 32.7,    alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id :  5, octave : 0, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 34.65,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id :  6, octave : 0, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 36.71,   alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id :  7, octave : 0, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 38.89,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id :  8, octave : 0, name : 'E',  enharmony : 'Fb', nameFr : 'Mi',   enharmonyFr : 'Fa♭',  frequency: 41.2,    alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id :  9, octave : 0, name : 'F',  enharmony : 'E#', nameFr : 'Fa',   enharmonyFr : 'Mi#',  frequency: 43.65,   alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 10, octave : 0, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 46.25,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 11, octave : 0, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 49.0,    alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 12, octave : 0, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 51.91,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 13, octave : 1, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 55.0,    alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 14, octave : 1, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 58.27,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 15, octave : 1, name : 'B',  enharmony : 'Cb', nameFr : 'Si',   enharmonyFr : 'Do♭',  frequency: 61.74,   alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 16, octave : 1, name : 'C',  enharmony : '',   nameFr : 'Do',   enharmonyFr : '',     frequency: 65.41,   alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 17, octave : 1, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 69.3,    alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 18, octave : 1, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 73.42,   alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 19, octave : 1, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 77.78,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 20, octave : 1, name : 'E',  enharmony : 'Fb', nameFr : 'Mi',   enharmonyFr : 'Fa♭',  frequency: 82.41,   alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 21, octave : 1, name : 'F',  enharmony : 'E#', nameFr : 'Fa',   enharmonyFr : 'Mi#',  frequency: 87.31,   alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 22, octave : 1, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 92.5,    alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 23, octave : 1, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 98.0,    alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 24, octave : 1, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 103.83,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 25, octave : 2, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 110.0,   alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 26, octave : 2, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 116.54,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 27, octave : 2, name : 'B',  enharmony : 'Cb', nameFr : 'Si',   enharmonyFr : 'Do♭',  frequency: 123.47,  alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 28, octave : 2, name : 'C',  enharmony : 'B#', nameFr : 'Do',   enharmonyFr : '',     frequency: 130.81,  alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 29, octave : 2, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 138.59,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 30, octave : 2, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 146.83,  alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 31, octave : 2, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 155.56,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 32, octave : 2, name : 'E',  enharmony : 'Fb', nameFr : 'Mi',   enharmonyFr : 'Fa♭',  frequency: 164.81,  alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 33, octave : 2, name : 'F',  enharmony : 'E#', nameFr : 'Fa',   enharmonyFr : 'Mi#',  frequency: 174.61,  alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 34, octave : 2, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 185.0,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 35, octave : 2, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 196.0,   alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 36, octave : 2, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 207.65,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 37, octave : 3, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 220.0,   alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 38, octave : 3, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 233.08,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 39, octave : 3, name : 'B',  enharmony : '',   nameFr : 'Si',   enharmonyFr : '',     frequency: 246.94,  alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 40, octave : 3, name : 'C',  enharmony : '',   nameFr : 'Do',   enharmonyFr : '',     frequency: 261.63,  alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 41, octave : 3, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 277.18,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 42, octave : 3, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 293.66,  alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 43, octave : 3, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 311.13,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 44, octave : 3, name : 'E',  enharmony : '',   nameFr : 'Mi',   enharmonyFr : '',     frequency: 329.63,  alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 45, octave : 3, name : 'F',  enharmony : '',   nameFr : 'Fa',   enharmonyFr : '',     frequency: 349.23,  alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 46, octave : 3, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 369.99,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 47, octave : 3, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 392.0,   alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 48, octave : 3, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 415.3,   alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 49, octave : 4, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 440.0,   alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 50, octave : 4, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 466.16,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 51, octave : 4, name : 'B',  enharmony : 'Cb', nameFr : 'Si',   enharmonyFr : 'Do♭',  frequency: 493.88,  alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 52, octave : 4, name : 'C',  enharmony : 'B#', nameFr : 'Do',   enharmonyFr : '',     frequency: 523.25,  alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 53, octave : 4, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 554.37,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 54, octave : 4, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 587.33,  alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 55, octave : 4, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 622.25,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 56, octave : 4, name : 'E',  enharmony : 'Fb', nameFr : 'Mi',   enharmonyFr : 'Fa♭',  frequency: 659.26,  alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 57, octave : 4, name : 'F',  enharmony : 'E#', nameFr : 'Fa',   enharmonyFr : 'Mi#',  frequency: 698.46,  alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 58, octave : 4, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 739.99,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 59, octave : 4, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 783.99,  alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 60, octave : 4, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 830.61,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 61, octave : 5, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 880.0,   alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 62, octave : 5, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 932.33,  alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 63, octave : 5, name : 'B',  enharmony : 'Cb', nameFr : 'Si',   enharmonyFr : 'Do♭',  frequency: 987.77,  alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 64, octave : 5, name : 'C',  enharmony : 'B#', nameFr : 'Do',   enharmonyFr : 'Si#',  frequency: 1046.5,  alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 65, octave : 5, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 1108.73, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 66, octave : 5, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 1174.66, alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 67, octave : 5, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 1244.51, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 68, octave : 5, name : 'E',  enharmony : 'Fb', nameFr : 'Mi',   enharmonyFr : 'Fa♭',  frequency: 1318.51, alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 69, octave : 5, name : 'F',  enharmony : '',   nameFr : 'Fa',   enharmonyFr : '',     frequency: 1396.91, alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 70, octave : 5, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 1479.98, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 71, octave : 5, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 1567.98, alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 72, octave : 5, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 1661.22, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 73, octave : 6, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 1760.0,  alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 74, octave : 6, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 1864.66, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 75, octave : 6, name : 'B',  enharmony : '',   nameFr : 'Si',   enharmonyFr : '',     frequency: 1975.53, alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 76, octave : 6, name : 'C',  enharmony : '',   nameFr : 'Do',   enharmonyFr : '',     frequency: 2093.0,  alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' },
    { id : 77, octave : 6, name : 'C#', enharmony : 'Db', nameFr : 'Do#',  enharmonyFr : 'Ré♭',  frequency: 2217.46, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 78, octave : 6, name : 'D',  enharmony : '',   nameFr : 'Ré',   enharmonyFr : '',     frequency: 2349.32, alteration : false, pressed : false, degree : 'ii',      degreeName : 'Super-Tonic',  degreeNameFr : 'Sus-Tonique' },
    { id : 79, octave : 6, name : 'D#', enharmony : 'Eb', nameFr : 'Ré#',  enharmonyFr : 'Mi♭',  frequency: 2489.02, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 80, octave : 6, name : 'E',  enharmony : '',   nameFr : 'Mi',   enharmonyFr : '',     frequency: 2637.02, alteration : false, pressed : false, degree : 'iii',     degreeName : 'Mediant',      degreeNameFr : 'Médiante' },
    { id : 81, octave : 6, name : 'F',  enharmony : '',   nameFr : 'Fa',   enharmonyFr : '',     frequency: 2793.83, alteration : false, pressed : false, degree : 'IV',      degreeName : 'Sub-Dominant', degreeNameFr : 'Sous-Dominante' },
    { id : 82, octave : 6, name : 'F#', enharmony : 'Gb', nameFr : 'Fa#',  enharmonyFr : 'Sol♭', frequency: 2959.96, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 83, octave : 6, name : 'G',  enharmony : '',   nameFr : 'Sol',  enharmonyFr : '',     frequency: 3135.96, alteration : false, pressed : false, degree : 'V',       degreeName : 'Dominant',     degreeNameFr : 'Dominante' },
    { id : 84, octave : 6, name : 'G#', enharmony : 'Ab', nameFr : 'Sol#', enharmonyFr : 'La♭',  frequency: 3322.44, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 85, octave : 7, name : 'A',  enharmony : '',   nameFr : 'La',   enharmonyFr : '',     frequency: 3520.0,  alteration : false, pressed : false, degree : 'vi',      degreeName : 'Sub-Mediant',  degreeNameFr : 'Sus-Dominante' },
    { id : 86, octave : 7, name : 'A#', enharmony : 'Bb', nameFr : 'La#',  enharmonyFr : 'Si♭',  frequency: 3729.31, alteration : true,  pressed : false, degree : '',        degreeName : '',             degreeNameFr : '' },
    { id : 87, octave : 7, name : 'B',  enharmony : '',   nameFr : 'Si',   enharmonyFr : '',     frequency: 3951.07, alteration : false, pressed : false, degree : 'vii(b5)', degreeName : 'Leading Tone', degreeNameFr : 'Sensible' },
    { id : 88, octave : 8, name : 'C',  enharmony : '',   nameFr : 'Do',   enharmonyFr : '',     frequency: 4186.01, alteration : false, pressed : false, degree : 'I',       degreeName : 'Tonic',        degreeNameFr : 'Tonique' }
  ] 

  chordsREF :    Chord[] = 
  [
    { id : 1, name : 'C Major', intervals : [], notes : [] }
  ]

  KeysREF :      Key[] = 
  [
    { id :  1, name : 'C',  enharmony : '',    nameFr : 'Do',    enharmonyFr : '',      scales : [new Scale()] },
    { id :  2, name : 'G',  enharmony : '',    nameFr : 'Sol',   enharmonyFr : '',      scales : [] },
    { id :  3, name : 'D',  enharmony : '',    nameFr : 'Ré',    enharmonyFr : '',      scales : [] },
    { id :  4, name : 'A',  enharmony : '',    nameFr : 'La',    enharmonyFr : '',      scales : [] },
    { id :  5, name : 'E',  enharmony : '',    nameFr : 'Mi',    enharmonyFr : '',      scales : [] },
    { id :  6, name : 'B',  enharmony : '',    nameFr : 'Si',    enharmonyFr : '',      scales : [] },
    { id :  7, name : 'F#', enharmony : 'G ♭', nameFr : 'Fa #',  enharmonyFr : 'Sol ♭', scales : [] },
    { id :  8, name : 'C#', enharmony : 'D ♭', nameFr : 'Do #',  enharmonyFr : 'Ré ♭',  scales : [] },
    { id :  9, name : 'G#', enharmony : 'A ♭', nameFr : 'Sol #', enharmonyFr : 'La ♭',  scales : [] },
    { id : 10, name : 'D#', enharmony : 'E ♭', nameFr : 'Ré #',  enharmonyFr : 'Mi ♭',  scales : [] },
    { id : 11, name : 'A#', enharmony : 'B ♭', nameFr : 'La #',  enharmonyFr : 'Si ♭',  scales : [] },
    { id : 12, name : 'F',  enharmony : '',    nameFr : 'Fa',    enharmonyFr : '',      scales : [] }
  ]
}
