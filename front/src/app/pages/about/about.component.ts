import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/user-interface/image-url.service';
import { environment } from '../../../environments/environment';
import { MoodService } from '../../services/http/mood.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrl: './about.component.scss'
})
export class AboutComponent {
  #moodService = inject(MoodService)
  #imageURLService = inject(ImageUrlService)

  public moodsFlow = this.#moodService.moodsFlow
  public environment : string = environment.apiBaseUrl

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string { 
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}