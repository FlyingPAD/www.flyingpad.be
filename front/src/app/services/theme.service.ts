import { inject, Injectable } from '@angular/core';
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from 'rxjs';
import { StorageProperties } from '../enumerations/storage-properties';
import { StorageService } from './storage.service';
import { Theme } from '../enumerations/themes';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {
  #storageService = inject(StorageService)
  private readonly FADE_DURATION: number = 750
  private readonly DEFAULT_THEME: Theme = Theme.Default

  #currentTheme = new BehaviorSubject<Theme>(this.DEFAULT_THEME)
  currentTheme = toSignal(this.#currentTheme)

  constructor() {
    const storedTheme = this.#storageService.getItem(StorageProperties.Theme) as Theme | null
    if (storedTheme && this.isValidTheme(storedTheme)) {
      this.setTheme(storedTheme)
    } else {
      this.setDefaultTheme()
    }
  }

  private isValidTheme(theme: string): boolean {
    return Object.values(Theme).includes(theme as Theme)
  }

  private storeTheme(theme: Theme): void {
    this.#storageService.setItem(StorageProperties.Theme, theme)
    this.#currentTheme.next(theme)
  }

  public setTheme(theme: Theme): void {
    document.body.classList.add('fade-background')
    document.documentElement.classList.add('fade-background')

    setTimeout(() => {
      const themeClasses = ['dark', 'blue', 'pink', 'green', 'orange']
      document.body.classList.remove(...themeClasses)
      document.documentElement.classList.remove(...themeClasses)

      document.body.classList.add(theme)
      document.documentElement.classList.add(theme)

      setTimeout(() => {
        document.body.classList.remove('fade-background')
        document.documentElement.classList.remove('fade-background')
      }, 100)
    }, this.FADE_DURATION)

    this.storeTheme(theme)
  }

  public setDefaultTheme(): void {
    this.setTheme(this.DEFAULT_THEME)
  }

  private themeColorMap: Record<Theme, string> = {
    [Theme.Default]: '#6b5240', 
    [Theme.Dark]: '#40526b',
    [Theme.Blue]: '#40526b',
    [Theme.Pink]: '#5f4c56',
    [Theme.Green]: '#3a613b',
    [Theme.Orange]: '#9f5f00',
  };
  
  public getCurrentColor(): string {
    const theme = this.#currentTheme.value ?? this.DEFAULT_THEME;
    return this.themeColorMap[theme] ?? '#000';
  }
}