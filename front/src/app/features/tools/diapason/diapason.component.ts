import { Component, HostListener, inject } from '@angular/core';
import { AudioService } from '../../../services/audio.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-diapason',
  templateUrl: './diapason.component.html',
  styleUrls: ['./diapason.component.scss']
})
export class DiapasonComponent {
  audioService = inject(AudioService);
  #router = inject(Router);

  currentVolume: number = 0.5;
  frequency: number = 440;

  constructor() {
    document.addEventListener('click', () => this.resumeAudioContext());
  }

  resumeAudioContext() {
    if (this.audioService.audioContext.state === 'suspended') {
      this.audioService.audioContext.resume();
    }
  }

  playNote() {
    this.resumeAudioContext();
    this.audioService.playFrequencyWithEnvelope(this.frequency, 2, this.currentVolume);
  }

  volumeUp() {
    this.currentVolume = Math.min(this.currentVolume + 0.1, 1);
  }

  volumeDown() {
    this.currentVolume = Math.max(this.currentVolume - 0.1, 0);
  }

  resetTune() {
    this.frequency = 440;
  }

  validateVolume() {
    if (this.currentVolume < 0) {
      this.currentVolume = 0;
    } else if (this.currentVolume > 1) {
      this.currentVolume = 1;
    }
  }

  validateFrequency() {
    if (this.frequency < 415.3) {
      this.frequency = 415.3;
    } else if (this.frequency > 466.16) {
      this.frequency = 466.16;
    }
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.code) {
      case 'NumpadAdd':
        this.volumeUp();
        break;
      case 'NumpadSubtract':
        this.volumeDown();
        break;
    }
  }
}
