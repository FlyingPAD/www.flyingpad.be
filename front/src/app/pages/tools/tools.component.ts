import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';

@Component({
  selector: 'app-tools',
  templateUrl: './tools.component.html',
  styleUrl: './tools.component.scss'
})
export class ToolsComponent {
  #imageURLService = inject(ImageUrlService)

  showCircleofFifths: boolean = true
  showChordWheel: boolean = false
  showDiapason: boolean = false
  showMiniKeys: boolean = false
  showTrainer: boolean = false
  showTuner: boolean = false

  private resetToggles() {
    this.showCircleofFifths = false
    this.showChordWheel = false
    this.showDiapason = false
    this.showMiniKeys = false
    this.showTrainer = false
    this.showTuner = false
  }
  
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
  toggleTuner() {
    this.resetToggles()
    this.showTuner = true
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}