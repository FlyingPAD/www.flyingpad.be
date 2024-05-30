import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ToolsRoutingModule } from './tools-routing.module';
import { ChordWheelSvgComponent } from './components/chord-wheel-svg/chord-wheel-svg.component';
import { ToolListComponent } from './components/tool-list/tool-list.component';
import { SharedModule } from '../shared/shared.module';
import { CircleOfFifthsComponent } from './components/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from './components/diapason/diapason.component';
import { FlyingKeysMiniComponent } from './components/flying-keys-mini/flying-keys-mini.component';;

@NgModule({
  declarations: 
  [
    ToolListComponent,
    ChordWheelSvgComponent,
    CircleOfFifthsComponent,
    DiapasonComponent,
    FlyingKeysMiniComponent
  ],
  imports: 
  [
    CommonModule,
    ToolsRoutingModule,
    SharedModule
  ],
  exports:
  [
    FlyingKeysMiniComponent
  ]
})
export class ToolsModule { }