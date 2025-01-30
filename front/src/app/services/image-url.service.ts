import { inject, Injectable } from '@angular/core';
import { ThemeService } from './theme.service';
import { Theme } from '../enumerations/themes';

@Injectable({
  providedIn: 'root'
})
export class ImageUrlService {
  #themeService = inject(ThemeService)
  currentTheme = this.#themeService.currentTheme

  public getImageURL(folderName: string, imageName: string, imageExtension: string): string {
    let theme: Theme = this.currentTheme() ?? Theme.Default

    return `assets/${folderName}/${theme}/${imageName}.${imageExtension}`
  }

  public getImageURLNoTheme(folderName: string, imageName: string, imageExtension: string): string {
    return `assets/${folderName}/${imageName}.${imageExtension}`
  }
}