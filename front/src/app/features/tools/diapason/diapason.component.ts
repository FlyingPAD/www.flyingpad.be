import { Component, HostListener, inject } from '@angular/core';
import { AudioService } from '../../../services/audio.service';

@Component({
  selector: 'app-diapason',
  templateUrl: './diapason.component.html',
  styleUrls: ['./diapason.component.scss']
})
export class DiapasonComponent {
  private audioService = inject(AudioService)

  public currentVolume: number = 0.5
  public volumeMIN: number = 0
  public volumeMAX: number = 1
  public currentFrequency: number = 440
  public frequencyMIN: number = 415.3
  public frequencyMAX: number = 466.16


  private keyActions: { [key: string]: () => void } = {
    'NumpadAdd': () => this.volumeUp(),
    'NumpadSubtract': () => this.volumeDown(),
    'ArrowLeft': () => this.setFrequency(-0.01),
    'ArrowRight': () => this.setFrequency(0.01),
    'Space': () => this.playNote(),
    'Numpad0': () => this.reset()
  };

  @HostListener('document:click')
  resumeAudioContextOnClick(): void {
    this.resumeAudioContext()
  }

  @HostListener('window:keydown', ['$event'])
  onKeyPress(event: KeyboardEvent): void {
    const action = this.keyActions[event.code]
    if (action) {
      action()
    }
  }

  private resumeAudioContext(): void {
    if (this.audioService.audioContext.state === 'suspended') {
      this.audioService.audioContext.resume()
    }
  }

  private setFrequency(value: number): void {
    this.currentFrequency += value
    this.validateFrequency()
  }

  private volumeUp(): void {
    this.currentVolume = Math.min(this.currentVolume + 0.1, this.volumeMAX)
  }

  private volumeDown(): void {
    this.currentVolume = Math.max(this.currentVolume - 0.1, this.volumeMIN)
  }

  public playNote(): void {
    this.resumeAudioContext()
    this.audioService.playFrequencyWithEnvelope(this.currentFrequency, 2, this.currentVolume)
  }

  public reset(): void {
    this.currentFrequency = 440
    this.currentVolume = 0.5
  }

  public validateVolume(): void {
    this.currentVolume = Math.min(Math.max(this.currentVolume, this.volumeMIN), this.volumeMAX)
  }

  public validateFrequency(): void {
    this.currentFrequency = Math.min(Math.max(this.currentFrequency, this.frequencyMIN), this.frequencyMAX)
  }
}