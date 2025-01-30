import { Component, inject } from '@angular/core';
import { ImageUrlService } from '../../services/image-url.service';
import { environment } from '../../../environments/environment';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrl: './about.component.scss'
})
export class AboutComponent {
  #flowService = inject(FlowService)
  #imageURLService = inject(ImageUrlService)

  public flow = this.#flowService.flow
  public environment : string = environment.apiBaseUrl

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string { 
    return this.#imageURLService.getImageURL(folderName, imageName, imageExtension)
  }
}