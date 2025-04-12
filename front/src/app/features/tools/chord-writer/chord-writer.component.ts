import { Component, OnInit, OnDestroy } from '@angular/core';
import { StorageService } from '../../../services/storage.service';

export interface Chord {
  name: string;
  notes: string[];
}

export const CHORDS: Chord[] = [
  { name: 'C',  notes: ['Do', 'Mi', 'Sol'] },
  { name: 'Dm', notes: ['Ré', 'Fa', 'La'] },
  { name: 'Em', notes: ['Mi', 'Sol', 'Si'] },
  { name: 'F',  notes: ['Fa', 'La', 'Do'] },
  { name: 'G',  notes: ['Sol', 'Si', 'Ré'] },
  { name: 'Am', notes: ['La', 'Do', 'Mi'] },
  { name: 'Bdim', notes: ['Si', 'Ré', 'Fa'] }
];

export interface Measure {
  index: number;
  // Chaque mesure contient un accord par beat (null si aucun accord)
  chords: (Chord | null)[];
}

export interface SongSection {
  sectionName: string;
  bpm: number;
  timeSignature: string;
  measures: Measure[];
}

@Component({
  selector: 'app-chord-writer',
  templateUrl: './chord-writer.component.html',
  styleUrls: ['./chord-writer.component.scss']
})
export class ChordWriterComponent implements OnInit, OnDestroy {
  public CHORDS = CHORDS
  // --- Modes de Vue ---
  public currentViewMode: 'edition' | 'save' | 'settings' | 'preview' | 'song' = 'edition';

  // --- Réglages Globaux ---
  public bpm: number = 120;
  public tickVolume: number = 0.5;
  public chordVolume: number = 0.5;
  public masterVolume: number = 1.0;
  public loopEnabled: boolean = false;
  public timeSignature: string = '4/4';
  public beatsPerMeasure: number = 4;
  public numberOfMeasures: number = 4; // par section par défaut

  // --- Tick Sound ---
  public tickSoundOptions: { name: string; file: string }[] = [
    { name: 'Default', file: 'assets/audio/metronome-tik.mp3' },
    { name: 'Kick', file: 'assets/audio/kick.mp3' }
  ];
  public selectedTickSound: string = this.tickSoundOptions[0].file;

  // --- Preset Progressions ---
  public presetProgressions: { name: string; progression: Chord[] }[] = [
    { name: 'I–V–vi–IV (C)', progression: [CHORDS[0], CHORDS[4], CHORDS[5], CHORDS[3]] },
    { name: 'vi–IV–I–V (C)', progression: [CHORDS[5], CHORDS[3], CHORDS[0], CHORDS[4]] }
  ];
  public selectedPreset: string = '';

  // --- Strum Pattern ---
  public strumEnabled: boolean = false;
  public strumDelay: number = 0.05;

  // --- Composition ---
  public compositionTitle: string = '';
  public compositionDescription: string = '';
  public savedCompositionTitles: string[] = [];

  // --- Structure de la Chanson ---
  public songSections: SongSection[] = [];

  // --- Lecture Audio ---
  public isPlaying: boolean = false;
  public activeBeat: number = -1;
  private currentTick: number = 0;
  private nextTickTime: number = 0;

  private audioContext: AudioContext;
  private tickBuffer!: AudioBuffer;
  private timerId: any;
  private scheduleAheadTime: number = 0.1;
  private lookahead: number = 25;
  private masterGain: GainNode;

  // --- Fréquences (Hz) ---
  private readonly NOTE_FREQUENCIES: { [key: string]: number } = {
    'Do': 261.63,
    'Ré': 293.66,
    'Mi': 329.63,
    'Fa': 349.23,
    'Sol': 392.00,
    'La': 440.00,
    'Si': 493.88
  };

  constructor(private storageService: StorageService) {
    this.audioContext = new AudioContext();
    this.masterGain = this.audioContext.createGain();
    this.masterGain.gain.value = this.masterVolume;
    this.masterGain.connect(this.audioContext.destination);
    // Initialisation de la structure avec une section par défaut
    this.initializeSongSections();
  }

  async ngOnInit(): Promise<void> {
    await this.loadTickSound();
    this.loadSavedCompositionTitles();
  }

  ngOnDestroy(): void {
    this.stop();
    this.audioContext.close();
  }

  // --- Initialisation de la structure de la chanson ---
  private initializeSongSections(): void {
    const measures: Measure[] = Array.from({ length: this.numberOfMeasures }, (_, i) => ({
      index: i,
      chords: Array(this.beatsPerMeasure).fill(null)
    }));
    this.songSections = [{
      sectionName: 'A',
      bpm: this.bpm,
      timeSignature: this.timeSignature,
      measures
    }];
  }

  // Pour la vue Edition, ce getter renvoie les mesures de la première section
  get measureArray(): Measure[] {
    return this.songSections[0]?.measures || [];
  }
  get beatArrayInMeasure(): number[] {
    return Array.from({ length: this.beatsPerMeasure }, (_, i) => i);
  }

  // --- Mise à jour dynamique des mesures ---
  public updateMeasures(): void {
    const section = this.songSections[0];
    const currentCount = section.measures.length;
    if (this.numberOfMeasures > currentCount) {
      for (let i = currentCount; i < this.numberOfMeasures; i++) {
        section.measures.push({ index: i, chords: Array(this.beatsPerMeasure).fill(null) });
      }
    } else if (this.numberOfMeasures < currentCount) {
      section.measures = section.measures.slice(0, this.numberOfMeasures);
    }
  }

  // --- Application d'un preset ---
  public applyPreset(): void {
    const preset = this.presetProgressions.find(p => p.name === this.selectedPreset);
    if (preset) {
      const section = this.songSections[0];
      section.measures = Array.from({ length: this.numberOfMeasures }, (_, i) => ({
        index: i,
        chords: Array(this.beatsPerMeasure).fill(null)
      }));
      for (let i = 0; i < section.measures.length; i++) {
        const chord = preset.progression[i % preset.progression.length];
        section.measures[i].chords = Array(this.beatsPerMeasure).fill(chord);
      }
    }
  }

  // --- Audio : Chargement du tick sound ---
  async loadTickSound(): Promise<void> {
    try {
      const response = await fetch(this.selectedTickSound);
      const arrayBuffer = await response.arrayBuffer();
      this.tickBuffer = await this.audioContext.decodeAudioData(arrayBuffer);
    } catch (error) {
      console.error('Erreur lors du chargement du tick sound', error);
    }
  }
  public onTickSoundChange(event: Event): void {
    const target = event.target as HTMLSelectElement;
    this.selectedTickSound = target.value;
    this.loadTickSound();
  }
  public updateMasterVolume(): void {
    if (this.masterGain) {
      this.masterGain.gain.value = this.masterVolume;
    }
  }

  // --- Getters pour le scheduling ---
  get flattenedMeasures(): { measure: Measure, bpm: number }[] {
    const flat: { measure: Measure, bpm: number }[] = [];
    for (const section of this.songSections) {
      for (const measure of section.measures) {
        flat.push({ measure, bpm: section.bpm });
      }
    }
    return flat;
  }
  get totalGlobalBeats(): number {
    return this.flattenedMeasures.length * this.beatsPerMeasure;
  }

  private scheduler(): void {
    const flat = this.flattenedMeasures;
    while (this.nextTickTime < this.audioContext.currentTime + this.scheduleAheadTime) {
      if (this.currentTick >= this.totalGlobalBeats) {
        if (this.loopEnabled) {
          this.currentTick = 0;
          if (this.nextTickTime < this.audioContext.currentTime) {
            this.nextTickTime = this.audioContext.currentTime;
          }
        } else {
          this.stop();
          return;
        }
      }
      const globalBeatIndex = this.currentTick;
      const measureIndex = Math.floor(globalBeatIndex / this.beatsPerMeasure);
      const beatInMeasure = globalBeatIndex % this.beatsPerMeasure;
      const currentMeasureInfo = flat[measureIndex];
      const beatDuration = 60 / currentMeasureInfo.bpm;
      // On privilégie l'accord déposé sur ce beat ; sinon, on prend l'accord par défaut (premier beat)
      let chordToPlay: Chord | null = currentMeasureInfo.measure.chords[beatInMeasure];
      if (!chordToPlay && beatInMeasure !== 0) {
        chordToPlay = currentMeasureInfo.measure.chords[0];
      }
      if (chordToPlay) {
        const duration = (beatInMeasure === 0) ? beatDuration * this.beatsPerMeasure : beatDuration;
        this.scheduleChord(this.nextTickTime, chordToPlay, duration);
      }
      this.scheduleTick(this.nextTickTime, globalBeatIndex, beatInMeasure, beatDuration);
      this.nextTickTime += beatDuration;
      this.currentTick++;
    }
  }

  private scheduleTick(time: number, beatIndex: number, beatInMeasure: number, beatDuration: number): void {
    if (!this.tickBuffer) return;
    const source = this.audioContext.createBufferSource();
    source.buffer = this.tickBuffer;
    const gainNode = this.audioContext.createGain();
    gainNode.gain.value = this.tickVolume;
    source.connect(gainNode).connect(this.masterGain);
    source.start(time);
    const delay = Math.max((time - this.audioContext.currentTime) * 1000, 0);
    setTimeout(() => {
      this.activeBeat = beatIndex;
      setTimeout(() => {
        if (this.activeBeat === beatIndex) {
          this.activeBeat = -1;
        }
      }, 100);
    }, delay);
  }

  private scheduleChord(time: number, chord: Chord, duration: number): void {
    chord.notes.forEach((note, i) => {
      const frequency = this.NOTE_FREQUENCIES[note];
      if (frequency) {
        const oscillator = this.audioContext.createOscillator();
        const gainNode = this.audioContext.createGain();
        oscillator.frequency.value = frequency;
        oscillator.type = 'sine';
        const noteTime = this.strumEnabled ? time + i * this.strumDelay : time;
        gainNode.gain.setValueAtTime(this.chordVolume, noteTime);
        gainNode.gain.linearRampToValueAtTime(0, noteTime + duration);
        oscillator.connect(gainNode).connect(this.masterGain);
        oscillator.start(noteTime);
        oscillator.stop(noteTime + duration);
      }
    });
  }

  // --- Contrôle de la lecture ---
  public start(): void {
    if (!this.isPlaying && this.tickBuffer) {
      this.isPlaying = true;
      this.currentTick = 0;
      this.nextTickTime = this.audioContext.currentTime + 0.05;
      this.activeBeat = -1;
      this.timerId = setInterval(() => this.scheduler(), this.lookahead);
    }
  }
  public stop(): void {
    this.isPlaying = false;
    if (this.timerId) {
      clearInterval(this.timerId);
      this.timerId = null;
    }
  }
  public reset(): void {
    this.stop();
    this.bpm = 120;
    this.timeSignature = '4/4';
    this.beatsPerMeasure = 4;
    this.numberOfMeasures = 4;
    this.tickVolume = 0.5;
    this.chordVolume = 0.5;
    this.masterVolume = 1.0;
    this.loopEnabled = false;
    this.activeBeat = -1;
    this.currentTick = 0;
    this.nextTickTime = this.audioContext.currentTime + 0.05;
    this.initializeSongSections();
    this.updateMasterVolume();
  }

  // --- Mise à jour de la métrique ---
  public onTimeSignatureChange(event: Event): void {
    const target = event.target as HTMLSelectElement;
    const newSignature = target.value;
    this.timeSignature = newSignature;
    const parts = newSignature.split('/');
    if (parts.length === 2) {
      const numerator = parseInt(parts[0], 10);
      if (!isNaN(numerator) && numerator > 0) {
        this.beatsPerMeasure = numerator;
      }
    }
  }

  // --- Drag & Drop pour déposer un accord sur une mesure entière ---
  public onDragStart(event: DragEvent, chord: Chord): void {
    event.dataTransfer?.setData('text/plain', chord.name);
  }
  public onDragOver(event: DragEvent): void {
    event.preventDefault();
  }
  public onDrop(event: DragEvent, measureIndex: number): void {
    event.preventDefault();
    const chordName = event.dataTransfer?.getData('text/plain');
    if (chordName) {
      const droppedChord = CHORDS.find((c: Chord) => c.name === chordName);
      if (droppedChord) {
        // Mise à jour de la première section (édition)
        this.songSections[0].measures[measureIndex].chords = Array(this.beatsPerMeasure).fill(droppedChord);
      }
    }
  }

  // --- Drag & Drop pour déplacer une mesure entre sections (vue Song) ---
  public onMeasureDragStart(event: DragEvent, measure: Measure): void {
    event.dataTransfer?.setData('text/plain', measure.index.toString());
  }
  public onDropSection(event: DragEvent, sectionIndex: number): void {
    event.preventDefault();
    const measureIndexStr = event.dataTransfer?.getData('text/plain');
    if (measureIndexStr) {
      const measureIndex = parseInt(measureIndexStr, 10);
      // Retire la mesure de toutes les sections
      for (let section of this.songSections) {
        section.measures = section.measures.filter((m: Measure) => m.index !== measureIndex);
      }
      // Ajoute la mesure à la section ciblée (on prend la mesure depuis la première section)
      const measure = this.songSections[0].measures.find((m: Measure) => m.index === measureIndex);
      if (measure) {
        this.songSections[sectionIndex].measures.push(measure);
      }
    }
  }

  // --- Gestion de la structure de la chanson ---
  public addSection(): void {
    const newSectionName = String.fromCharCode(65 + this.songSections.length);
    this.songSections.push({
      sectionName: newSectionName,
      bpm: this.bpm,
      timeSignature: this.timeSignature,
      measures: []
    });
  }
  public deleteSection(index: number): void {
    if (this.songSections.length > 1) {
      this.songSections.splice(index, 1);
    }
  }
  public moveSectionUp(index: number): void {
    if (index > 0) {
      [this.songSections[index - 1], this.songSections[index]] = [this.songSections[index], this.songSections[index - 1]];
    }
  }
  public moveSectionDown(index: number): void {
    if (index < this.songSections.length - 1) {
      [this.songSections[index], this.songSections[index + 1]] = [this.songSections[index + 1], this.songSections[index]];
    }
  }

  // --- Sauvegarde et Gestion des compositions ---
  public saveComposition(): void {
    if (!this.compositionTitle.trim()) {
      console.error("Veuillez entrer un titre pour la composition.");
      return;
    }
    const composition = {
      title: this.compositionTitle,
      description: this.compositionDescription,
      bpm: this.bpm,
      tickVolume: this.tickVolume,
      chordVolume: this.chordVolume,
      masterVolume: this.masterVolume,
      loopEnabled: this.loopEnabled,
      timeSignature: this.timeSignature,
      beatsPerMeasure: this.beatsPerMeasure,
      numberOfMeasures: this.numberOfMeasures,
      measures: this.songSections[0].measures,
      songSections: this.songSections
    };
    this.storageService.setItem("composition_" + this.compositionTitle, composition);
    this.loadSavedCompositionTitles();
  }
  public loadComposition(title: string): void {
    const composition = this.storageService.getItem<any>("composition_" + title);
    if (composition) {
      this.compositionTitle = composition.title;
      this.compositionDescription = composition.description;
      this.bpm = composition.bpm;
      this.tickVolume = composition.tickVolume;
      this.chordVolume = composition.chordVolume;
      this.masterVolume = composition.masterVolume;
      this.loopEnabled = composition.loopEnabled;
      this.timeSignature = composition.timeSignature;
      this.beatsPerMeasure = composition.beatsPerMeasure;
      this.numberOfMeasures = composition.numberOfMeasures;
      this.songSections = composition.songSections || [{
        sectionName: 'A',
        bpm: this.bpm,
        timeSignature: this.timeSignature,
        measures: composition.measures || []
      }];
      this.currentTick = 0;
      this.nextTickTime = this.audioContext.currentTime + 0.05;
      this.updateMasterVolume();
    }
  }
  public deleteComposition(title: string): void {
    this.storageService.removeItem("composition_" + title);
    this.loadSavedCompositionTitles();
  }
  private loadSavedCompositionTitles(): void {
    this.savedCompositionTitles = [];
    for (let i = 0; i < localStorage.length; i++) {
      const key = localStorage.key(i);
      if (key && key.startsWith("composition_")) {
        this.savedCompositionTitles.push(key.replace("composition_", ""));
      }
    }
  }
  public downloadComposition(): void {
    if (!this.compositionTitle.trim()) {
      console.error("Veuillez entrer un titre pour la composition avant de télécharger.");
      return;
    }
    const composition = {
      title: this.compositionTitle,
      description: this.compositionDescription,
      bpm: this.bpm,
      tickVolume: this.tickVolume,
      chordVolume: this.chordVolume,
      masterVolume: this.masterVolume,
      loopEnabled: this.loopEnabled,
      timeSignature: this.timeSignature,
      beatsPerMeasure: this.beatsPerMeasure,
      numberOfMeasures: this.numberOfMeasures,
      measures: this.songSections[0].measures,
      songSections: this.songSections
    };
    const blob = new Blob([JSON.stringify(composition, null, 2)], { type: 'application/json' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = `${this.compositionTitle}.json`;
    a.click();
    URL.revokeObjectURL(url);
  }
  public loadCompositionFromFile(event: Event): void {
    const input = event.target as HTMLInputElement;
    if (input.files && input.files.length > 0) {
      const file = input.files[0];
      const reader = new FileReader();
      reader.onload = (e) => {
        try {
          const data = JSON.parse(e.target?.result as string);
          this.compositionTitle = data.title || '';
          this.compositionDescription = data.description || '';
          this.bpm = data.bpm || 120;
          this.tickVolume = data.tickVolume || 0.5;
          this.chordVolume = data.chordVolume || 0.5;
          this.masterVolume = data.masterVolume || 1.0;
          this.loopEnabled = data.loopEnabled || false;
          this.timeSignature = data.timeSignature || '4/4';
          this.beatsPerMeasure = data.beatsPerMeasure || 4;
          this.numberOfMeasures = data.numberOfMeasures || 4;
          this.songSections = data.songSections || [{
            sectionName: 'A',
            bpm: this.bpm,
            timeSignature: this.timeSignature,
            measures: data.measures || []
          }];
          this.currentTick = 0;
          this.nextTickTime = this.audioContext.currentTime + 0.05;
          this.updateMasterVolume();
        } catch (error) {
          console.error("Erreur lors du chargement du fichier JSON", error);
        }
      };
      reader.readAsText(file);
    }
  }

  // --- Changement de mode ---
  public setViewMode(viewMode: 'edition' | 'save' | 'settings' | 'preview' | 'song'): void {
    this.currentViewMode = viewMode;
  }

  // --- Impression ---
  public printPreview(): void {
    window.print();
  }
}