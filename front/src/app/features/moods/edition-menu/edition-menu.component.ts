import { Component, EventEmitter, inject, Input, Output } from '@angular/core';
import { MoodFull } from '../../../interfaces/mood';
import { ImageUrlService } from '../../../services/display/image-url.service';

@Component({
  selector: 'app-edition-menu',
  templateUrl: './edition-menu.component.html',
  styleUrl: './edition-menu.component.scss'
})
export class EditionMenuComponent {
  #imageURLService = inject(ImageUrlService)
  @Input() mood! : MoodFull
  @Input() environment! : string
  @Output() showDetails = new EventEmitter<void>() 
  @Output() showGallery = new EventEmitter<void>() 

  triggerMoodEdition : boolean = true
  triggerMoodTagsEdition : boolean = false
  triggerMoodModelsEdition : boolean = false
  triggerMoodArtistsEdition : boolean = false

  triggerReset():void {
    this.triggerMoodEdition = false
    this.triggerMoodTagsEdition = false
    this.triggerMoodModelsEdition = false
    this.triggerMoodArtistsEdition = false
  }
  triggerMoodEditionButton():void {
    this.triggerReset()
    this.triggerMoodEdition = true
  }
  triggerMoodTagsEditionButton():void {
    this.triggerReset()
    this.triggerMoodTagsEdition = true
  }
  triggerMoodArtistsEditionButton():void {
    this.triggerReset()
    this.triggerMoodArtistsEdition = true
  }
  triggerMoodModelsEditionButton():void {
    this.triggerReset()
    this.triggerMoodModelsEdition = true
  }

  handleShowDetails(){
    this.showDetails.emit()
  }

  handleShowGallery(){
    this.showGallery.emit()
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}