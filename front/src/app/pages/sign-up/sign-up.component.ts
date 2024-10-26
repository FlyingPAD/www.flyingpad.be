import { Component, inject } from '@angular/core';
import { environment } from '../../../environments/environment';
import { ImageUrlService } from '../../services/display/image-url.service';
import { LanguageService } from '../../services/display/language.service';
import { FlowService } from '../../services/flow.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrl: './sign-up.component.scss'
})
export class SignUpComponent {
  #flowService = inject(FlowService)
  #languageService = inject(LanguageService)
  #imageUrlService = inject(ImageUrlService)
  
  public flow = this.#flowService.flow
  public currentLanguage = this.#languageService.currentLanguage
  public environment: string = environment.apiBaseUrl
  public closeButtonIsOn: boolean = false

  ngOnInit(): void {
    setTimeout( () => {
      this.closeButtonIsOn = true
    }, 500)
  }

  public isLanguageMenuON : boolean = false

  public languageMenuToggle(): void {
    this.isLanguageMenuON = !this.isLanguageMenuON
  }

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    return this.#imageUrlService.getImageURL(folderName, imageName, imageExtension)
  }
}