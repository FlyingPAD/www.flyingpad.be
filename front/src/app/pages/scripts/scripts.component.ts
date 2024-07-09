import { Component } from '@angular/core';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrl: './scripts.component.scss'
})
export class ScriptsComponent {
  currentScript: string = '';

  selectScript(scriptName: string) {
    this.currentScript = scriptName;
  }
}
