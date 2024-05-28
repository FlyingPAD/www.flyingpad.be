import { Component, HostListener, inject } from '@angular/core';
import { AudioService } from '../../../core/services/audio.service';
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

  constructor() {
    // Resume audio context on any interaction
    document.addEventListener('click', () => this.resumeAudioContext());
  }

  resumeAudioContext() {
    if (this.audioService.audioContext.state === 'suspended') {
      this.audioService.audioContext.resume();
    }
  }

  playNote() {
    this.resumeAudioContext();
    this.audioService.playFrequencyWithEnvelope(440, 2, this.currentVolume);
  }

  volumeUp() {
    if (this.currentVolume >= 1) this.currentVolume = 1;
    else this.currentVolume += 0.1;
  }

  volumeDown() {
    if (this.currentVolume <= 0) this.currentVolume = 0;
    else this.currentVolume -= 0.1;
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent) {
    switch (event.code) {
      case 'Backspace':
        this.#router.navigateByUrl('/tools');
        break;
      case 'NumpadAdd':
        this.volumeUp();
        break;
      case 'NumpadSubtract':
        this.volumeDown();
        break;
    }
  }
}
