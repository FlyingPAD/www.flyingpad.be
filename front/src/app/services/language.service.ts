import { inject, Injectable, Signal } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { TranslateService } from '@ngx-translate/core';
import { ToastrService } from 'ngx-toastr';
import { BehaviorSubject } from 'rxjs';
import { StorageProperties } from '../enumerations/storage-properties';
import { SupportedLanguages } from '../enumerations/supported-languages';
import { StorageService } from './storage.service';

@Injectable({
  providedIn: 'root'
})
export class LanguageService {
  #translateService = inject(TranslateService)
  #storageService = inject(StorageService)
  #toastr = inject(ToastrService)

  private readonly DEFAULT_LANGUAGE: SupportedLanguages = SupportedLanguages.FR
  #currentLanguage = new BehaviorSubject<string>(this.DEFAULT_LANGUAGE)
  public currentLanguage: Signal<string> = toSignal(this.#currentLanguage, {initialValue : this.DEFAULT_LANGUAGE })

  constructor() {
    let storedLanguage: string | null = this.#storageService.getItem(StorageProperties.Language)

    if (storedLanguage) {
      this.setLanguage(storedLanguage)
    } else {
      this.#translateService.setDefaultLang(this.DEFAULT_LANGUAGE)
      this.#translateService.use(this.DEFAULT_LANGUAGE)
      this.#storageService.setItem(StorageProperties.Language, this.DEFAULT_LANGUAGE)
    }
  }

  private isValidLanguage(language: string): boolean {
    let validationResult : boolean = Object.values(SupportedLanguages).includes(language as SupportedLanguages)

    if(validationResult === false) {
      this.#toastr.error(`Invalid language detected : ${language.toUpperCase()}. Falling back to default language.`)
    }
    return validationResult
  }

  public setLanguage(language: string): void {
    if (this.isValidLanguage(language)) {
      this.#translateService.setDefaultLang(language)
      this.#translateService.use(language)
      this.#currentLanguage.next(language)
      this.#storageService.setItem(StorageProperties.Language, language)
    }
  }

  public resetLanguage(): void {
    this.setLanguage(this.DEFAULT_LANGUAGE)
  }
}