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
  ],
  imports: [
    CommonModule,
    ScriptsRoutingModule,
    SharedModule
  ]
})
export class ScriptsModule { }
