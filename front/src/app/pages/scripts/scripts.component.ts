import { Component } from '@angular/core';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent {
  currentScript: string = 'introduction'

  selectScript(scriptName: string): void {
    this.currentScript = scriptName
  }
}