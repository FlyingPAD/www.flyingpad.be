import { Component } from '@angular/core';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss'
})
export class ToolsComponent {
  showCircleofFifths: boolean = false
  showChordWheel: boolean = false
  showDiapason: boolean = false
  showMiniKeys: boolean = false
  showTrainer: boolean = false

  toggleCircleofFifths() {
    this.resetToggles()
    this.showCircleofFifths = true
  }

  toggleChordWheel() {
    this.resetToggles()
    this.showChordWheel = true
  }

  toggleDiapason() {
    this.resetToggles()
    this.showDiapason = true
  }

  toggleMiniKeys() {
    this.resetToggles()
    this.showMiniKeys = true
  }

  toggleTrainer() {
    this.resetToggles()
    this.showTrainer = true
  }

  private resetToggles() {
    this.showCircleofFifths = false
    this.showChordWheel = false
    this.showDiapason = false
    this.showMiniKeys = false
    this.showTrainer = false
  }
}
