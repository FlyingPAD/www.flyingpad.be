import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ChordWheelComponent } from '../../features/tools/chord-wheel/chord-wheel.component';
import { CircleOfFifthsComponent } from '../../features/tools/circle-of-fifths/circle-of-fifths.component';
import { DiapasonComponent } from '../../features/tools/diapason/diapason.component';
import { TrainerNotesComponent } from '../../features/tools/trainer-notes/trainer-notes.component';
import { FlyingKeysMiniComponent } from '../../features/tools/flying-keys-mini/flying-keys-mini.component';
import { elasticEffect, fadeInOut, rotate, slideInAnimation, zoomInZoomOut } from '../../animations/animations';

@Component({
  selector: 'app-tools',
  standalone: true,
  imports: [CommonModule, ChordWheelComponent, CircleOfFifthsComponent, DiapasonComponent, TrainerNotesComponent, FlyingKeysMiniComponent],
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss',
  animations: [slideInAnimation, fadeInOut, zoomInZoomOut, rotate, elasticEffect]
})
export class ToolsComponent 
{
  currentTool: string = ''

  selectTool(toolName: string) {
    this.currentTool = toolName
  }
}