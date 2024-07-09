import { Component } from '@angular/core';
import { ButtonTopComponent } from '../../components/button-top/button-top.component';
import { CommonModule } from '@angular/common';
import { ChordsComponent } from '../../features/scripts/chords/chords.component';
import { IntervalsComponent } from '../../features/scripts/intervals/intervals.component';
import { IntroductionComponent } from '../../features/scripts/introduction/introduction.component';
import { KeysReferenceComponent } from '../../features/scripts/keys-reference/keys-reference.component';
import { LearnMusicComponent } from '../../features/scripts/learn-music/learn-music.component';
import { MelodyComponent } from '../../features/scripts/melody/melody.component';
import { MetricsAComponent } from '../../features/scripts/metrics-a/metrics-a.component';
import { MetricsBComponent } from '../../features/scripts/metrics-b/metrics-b.component';
import { NotationComponent } from '../../features/scripts/notation/notation.component';
import { NotesComponent } from '../../features/scripts/notes/notes.component';
import { NotesExComponent } from '../../features/scripts/notes-ex/notes-ex.component';
import { NotesTradComponent } from '../../features/scripts/notes-trad/notes-trad.component';
import { PointOfViewComponent } from '../../features/scripts/point-of-view/point-of-view.component';
import { PulsationComponent } from '../../features/scripts/pulsation/pulsation.component';
import { ScalesComponent } from '../../features/scripts/scales/scales.component';
import { slideInAnimation } from '../../animations/animations';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-scripts',
  standalone: true,
  imports: 
  [
    CommonModule, 
    RouterModule,
    ButtonTopComponent, 
    ChordsComponent, 
    IntervalsComponent, 
    IntroductionComponent, 
    KeysReferenceComponent,
    LearnMusicComponent,
    MelodyComponent,
    MetricsAComponent,
    MetricsBComponent,
    NotationComponent,
    NotesComponent,
    NotesExComponent,
    NotesTradComponent,
    PointOfViewComponent,
    PulsationComponent,
    ScalesComponent
  ],
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss',
  animations: [slideInAnimation]
})
export class ScriptsComponent {
  currentScript: string = '';

  selectScript(scriptName: string) {
    this.currentScript = scriptName;
  }
}