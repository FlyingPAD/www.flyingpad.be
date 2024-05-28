import { Component, inject } from '@angular/core';
import { AudioService } from '../../../core/services/audio.service';

@Component({
  selector: 'app-diapason',
  templateUrl: './diapason.component.html',
  styleUrl: './diapason.component.scss'
})
export class DiapasonComponent 
{
  audioService = inject(AudioService)

  playNote()
  {
    this.audioService.playFrequencyWithEnvelope(440, 2, 1)
  }
}