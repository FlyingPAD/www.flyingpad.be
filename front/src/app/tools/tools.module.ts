import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ToolsRoutingModule } from './tools-routing.module';
import { ChordWheelSvgComponent } from './components/chord-wheel-svg/chord-wheel-svg.component';
import { ToolListComponent } from './components/tool-list/tool-list.component';
import { SharedModule } from '../shared/shared.module';
import { CircleOfFifthsComponent } from './components/circle-of-fifths/circle-of-fifths.component';;

@NgModule({
  declarations: 
  [
    ToolListComponent,
    ChordWheelSvgComponent,
    CircleOfFifthsComponent
  ],
  imports: 
  [
    CommonModule,
    ToolsRoutingModule,
    SharedModule
  ]
})
export class ToolsModule { }