import { Component } from '@angular/core';
import { StorageService } from '../../../services/storage.service';

export interface Chord {
  name: string;
  notes: string[];
}

// Bibliothèque d'accords étendue
export const CHORDS: Chord[] = [
  { name: 'C', notes: ['Do', 'Mi', 'Sol'] },
  { name: 'Dm', notes: ['Ré', 'Fa', 'La'] },
  { name: 'Em', notes: ['Mi', 'Sol', 'Si'] },
  { name: 'F', notes: ['Fa', 'La', 'Do'] },
  { name: 'G', notes: ['Sol', 'Si', 'Ré'] },
  { name: 'Am', notes: ['La', 'Do', 'Mi'] },
  { name: 'Bdim', notes: ['Si', 'Ré', 'Fa'] }
];

export interface Measure {
  index: number;
  assignedChord: Chord | null;
}

@Component({
  selector: 'app-song-writer',
  templateUrl: './song-writer.component.html',
  styleUrl: './song-writer.component.scss'
})
export class SongWriterComponent {
  // --- Contrôles utilisateur ---
  public currentViewMode: 'edition' | 'save' | 'settings' | 'preview' = 'edition';
  public bpm: number = 120;
  public tickVolume: number = 0.5;
  public chordVolume: number = 0.5;
  public masterVolume: number = 1.0;
  public loopEnabled: boolean = false;
  public timeSignature: string = '4/4';
  public beatsPerMeasure: number = 4;
  public numberOfMeasures: number = 4;

  // Tick sound options (pré-définis)
  public tickSoundOptions: { name: string; file: string }[] = [
    { name: 'Default', file: 'assets/audio/metronome-tik.mp3' },
    { name: 'Kick', file: 'assets/audio/kick.mp3' }
  ];
  public selectedTickSound: string = this.tickSoundOptions[0].file;

  // --- Gestion de la composition ---
  public compositionTitle: string = '';
  public compositionDescription: string = '';
  public savedCompositionTitles: string[] = [];

  // --- État de la lecture ---
  public isPlaying: boolean = false;
  public activeBeat: number = -1;
  // Tableau des mesures (chaque mesure est un objet Measure)
  public measures: Measure[] = [];
  // Liste des accords disponibles (pour drag & drop)
  public chords: Chord[] = CHORDS;

  // --- Gestion audio ---
  private audioContext: AudioContext;
  private tickBuffer!: AudioBuffer;
  private nextTickTime: number = 0;
  private timerId: any;
  private scheduleAheadTime: number = 0.1; // secondes
  private lookahead: number = 25; // millisecondes
  private currentTick: number = 0;
  private masterGain: GainNode;

  // Mapping des notes vers leurs fréquences (Hz)
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
    // Création du masterGain et connexion à la destination audio
    this.masterGain = this.audioContext.createGain();
    this.masterGain.gain.value = this.masterVolume;
    this.masterGain.connect(this.audioContext.destination);
    this.initializeMeasures();
  }

  async ngOnInit(): Promise<void> {
    await this.loadTickSound();
    this.loadSavedCompositionTitles();
  }

  ngOnDestroy(): void {
    this.stop();
    this.audioContext.close();
  }

  // --- Initialisation des mesures ---
  private initializeMeasures(): void {
    this.measures = Array.from({ length: this.numberOfMeasures }, (_, i) => ({
      index: i,
      assignedChord: null
    }));
  }

  // Méthode pour mettre à jour dynamiquement le tableau des mesures lorsque numberOfMeasures change
  public updateMeasures(): void {
    const currentCount = this.measures.length;
    if (this.numberOfMeasures > currentCount) {
      for (let i = currentCount; i < this.numberOfMeasures; i++) {
        this.measures.push({ index: i, assignedChord: null });
      }
    } else if (this.numberOfMeasures < currentCount) {
      this.measures = this.measures.slice(0, this.numberOfMeasures);
    }
  }

  // --- Chargement du tick sound ---
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

  // --- Mise à jour du master volume ---
  public updateMasterVolume(): void {
    if (this.masterGain) {
      this.masterGain.gain.value = this.masterVolume;
    }
  }

  // --- Getters pour l'affichage ---
  get totalBeats(): number {
    return this.numberOfMeasures * this.beatsPerMeasure;
  }
  get measureArray(): Measure[] {
    return this.measures;
  }
  get beatArrayInMeasure(): number[] {
    return Array.from({ length: this.beatsPerMeasure }, (_, i) => i);
  }

  // --- Scheduling Audio ---
  private scheduler(): void {
    while (this.nextTickTime < this.audioContext.currentTime + this.scheduleAheadTime) {
      if (this.currentTick >= this.totalBeats) {
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
      const beatIndex = this.currentTick;
      const beatInMeasure = beatIndex % this.beatsPerMeasure;
      if (beatInMeasure === 0) {
        const measureIndex = Math.floor(this.currentTick / this.beatsPerMeasure);
        const chord = this.measures[measureIndex]?.assignedChord;
        if (chord) {
          this.scheduleChord(this.nextTickTime, chord);
        }
      }
      this.scheduleTick(this.nextTickTime, beatIndex, beatInMeasure);
      this.nextTickTime += 60 / this.bpm;
      this.currentTick++;
    }
  }

  private scheduleTick(time: number, beatIndex: number, beatInMeasure: number): void {
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

  private scheduleChord(time: number, chord: Chord): void {
    const measureDuration = (this.beatsPerMeasure * 60) / this.bpm;
    chord.notes.forEach(note => {
      const frequency = this.NOTE_FREQUENCIES[note];
      if (frequency) {
        const oscillator = this.audioContext.createOscillator();
        const gainNode = this.audioContext.createGain();
        oscillator.frequency.value = frequency;
        oscillator.type = 'sine';
        gainNode.gain.setValueAtTime(this.chordVolume, time);
        gainNode.gain.linearRampToValueAtTime(0, time + measureDuration);
        oscillator.connect(gainNode).connect(this.masterGain);
        oscillator.start(time);
        oscillator.stop(time + measureDuration);
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
    this.initializeMeasures();
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

  // --- Gestion du Drag & Drop ---
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
      const droppedChord = this.chords.find(c => c.name === chordName);
      if (droppedChord) {
        this.measures[measureIndex].assignedChord = droppedChord;
      }
    }
  }

  // --- Sauvegarde et gestion des compositions ---
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
      measures: this.measures
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
      this.measures = composition.measures;
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

  // Téléchargement de la composition en JSON
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
      measures: this.measures
    };
    const blob = new Blob([JSON.stringify(composition, null, 2)], { type: 'application/json' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = `${this.compositionTitle}.json`;
    a.click();
    URL.revokeObjectURL(url);
  }

  // Chargement d'une composition depuis un fichier JSON
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
          this.measures = data.measures || [];
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

  // --- Changement de mode d'affichage ---
  public setViewMode(viewMode: 'edition' | 'save' | 'settings' | 'preview'): void {
    this.currentViewMode = viewMode;
  }

  // --- Mode Preview pour l'impression ---
  public printPreview(): void {
    window.print();
  }
}