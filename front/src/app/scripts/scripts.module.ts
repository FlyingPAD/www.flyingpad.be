import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ScriptsRoutingModule } from './scripts-routing.module';
import { ListComponent } from './components/list/list.component';
import { SharedModule } from '../shared/shared.module';
import { IntroComponent } from './components/intro/intro.component';
import { KeyRefComponent } from './components/key-ref/key-ref.component';
import { MetricsAComponent } from './components/metrics-a/metrics-a.component';
import { NotesTradComponent } from './components/notes-trad/notes-trad.component';
import { NotesComponent } from './components/notes/notes.component';
import { PulsationComponent } from './components/pulsation/pulsation.component';
import { IntervalsComponent } from './components/intervals/intervals.component';
import { ChordsComponent } from './components/chords/chords.component';
import { ScalesComponent } from './components/scales/scales.component';
import { NotationComponent } from './components/notation/notation.component';
import { MelodyComponent } from './components/melody/melody.component';
import { MetricsBComponent } from './components/metrics-b/metrics-b.component';
import { NotesExComponent } from './components/notes-ex/notes-ex.component';
import { LearnMusicComponent } from './components/learn-music/learn-music.component';
import { ViewpointComponent } from './components/viewpoint/viewpoint.component';
import { ToolsModule } from '../tools/tools.module';


@NgModule({
  declarations: 
  [
    ListComponent,
    NotesComponent,
    NotesTradComponent,
    PulsationComponent,
    MetricsAComponent,
    IntroComponent,
    KeyRefComponent,
    IntervalsComponent,
    ChordsComponent,
    ScalesComponent,
    NotationComponent,
    MelodyComponent,
    MetricsBComponent,
    NotesExComponent,
    LearnMusicComponent,
    ViewpointComponent,
  ],
  imports: [
    CommonModule,
    ScriptsRoutingModule,
    SharedModule,
    ToolsModule
  ]
})
export class ScriptsModule { }
