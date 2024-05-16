import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './components/list/list.component';
import { IntroComponent } from './components/intro/intro.component';
import { KeyRefComponent } from './components/key-ref/key-ref.component';
import { MetricsAComponent } from './components/metrics-a/metrics-a.component';
import { NotesTradComponent } from './components/notes-trad/notes-trad.component';
import { NotesComponent } from './components/notes/notes.component';
import { PulsationComponent } from './components/pulsation/pulsation.component';
import { IntervalsComponent } from './components/intervals/intervals.component';
import { ScalesComponent } from './components/scales/scales.component';
import { ChordsComponent } from './components/chords/chords.component';
import { NotationComponent } from './components/notation/notation.component';
import { MetricsBComponent } from './components/metrics-b/metrics-b.component';
import { MelodyComponent } from './components/melody/melody.component';

const routes: Routes = 
[
  { path : '', redirectTo: 'list', pathMatch: 'full' },
  { path : 'list', component : ListComponent, title : 'Flying PAD | Tools List' },
  
  { path : 'introduction', component : IntroComponent, title : 'Flying PAD | Introduction' },
  { path : 'piano-reference', component : KeyRefComponent, title : 'Flying PAD | Référence' },
  { path : 'notation', component : NotationComponent, title : 'Flying PAD | La Notation Musicale' },
  
  { path : 'notes-fr', component : NotesComponent, title : 'Flying PAD | Les Notes' },
  { path : 'notes-en', component : NotesTradComponent, title : 'Flying PAD | Notes' },
  { path : 'pulsation', component : PulsationComponent, title : 'Flying PAD | La Pulsation' },
  { path : 'metrics-a', component : MetricsAComponent, title : 'Flying PAD | Les Métriques ( 1 )' },
  { path : 'metrics-b', component : MetricsBComponent, title : 'Flying PAD | Les Métriques ( 2 )' },
  { path : 'intervals', component : IntervalsComponent, title : 'Flying PAD | Les Intervalles' },
  { path : 'chords', component : ChordsComponent, title : 'Flying PAD | Les Accords' },
  { path : 'scales', component : ScalesComponent, title : 'Flying PAD | Les Gammes' },
  { path : 'melody', component : MelodyComponent, title : 'Flying PAD | La Mélodie' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ScriptsRoutingModule { }
