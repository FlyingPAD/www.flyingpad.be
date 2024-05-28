import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ToolListComponent } from './components/tool-list/tool-list.component';
import { ChordWheelSvgComponent } from './components/chord-wheel-svg/chord-wheel-svg.component';
import { CircleOfFifthsComponent } from './components/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './components/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './components/flying-keys-mini/flying-keys-mini.component';

const routes: Routes = 
[
  { path : '', redirectTo: 'list', pathMatch: 'full' },
  { path : 'list', component : ToolListComponent, title : 'Flying PAD | Tools List' },

  { path : 'chord-wheel', component : ChordWheelSvgComponent, title : 'Flying PAD | Chord Wheel' },
  { path : 'circle-of-fifths', component : CircleOfFifthsComponent, title : 'Flying PAD | Circle of Fifths' },
  { path : 'diapason', component : DiapasonComponent, title : 'Flying PAD | Diapason' },
  { path : 'flying-keys-mini', component : FlyingKeysMiniComponent, title : 'Flying PAD | Flying Keys ( Mini )' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ToolsRoutingModule { }
