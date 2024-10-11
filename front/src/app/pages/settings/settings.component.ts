import { Component, inject, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { AppSettingsService } from '../../services/app-settings.service';


@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.scss']
})
export class SettingsComponent implements OnInit {

  appSettings = inject(AppSettingsService)
  translateService = inject(TranslateService)
  currentLanguage: string = 'fr'; 


  ngOnInit(): void {
    this.translateService.setDefaultLang('fr');
  }

  switchLanguage(language: string): void {
    this.translateService.use(language);
    this.currentLanguage = this.translateService.currentLang;
  }

  toggleFullScreen(): void {
    this.appSettings.toggleFullscreen()
  }
}