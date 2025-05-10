import { inject, Injectable, Signal } from '@angular/core';
import { BehaviorSubject, combineLatest, fromEvent } from 'rxjs';
import { debounceTime, startWith, map } from 'rxjs/operators';
import { toSignal } from '@angular/core/rxjs-interop';
import { DisplayModes } from '../../enumerations/display-modes';
import { DisplayOrientations } from '../../enumerations/display-orientations';
import { DisplayInfo } from '../../interfaces/display-info';
import { MenuService } from './menu.service';

@Injectable({
  providedIn: 'root'
})
export class DisplayService {
  private readonly MOBILE_BREAKPOINT = 768
  #menuService = inject(MenuService)
  #windowWidth = new BehaviorSubject<number>(window.innerWidth)
  #windowHeight = new BehaviorSubject<number>(window.innerHeight)
  #displayMode = new BehaviorSubject<DisplayModes>(this.detectDisplayMode())
  #displayOrientation = new BehaviorSubject<DisplayOrientations>(this.detectDisplayOrientation())

  private displayInfo$ = combineLatest([
    this.#windowWidth,
    this.#windowHeight,
    this.#displayMode,
    this.#displayOrientation
  ]).pipe(
    map(([width, height, mode, orientation]) => ({ width, height, mode, orientation }))
  )

  public displayInfo: Signal<DisplayInfo> = toSignal(this.displayInfo$, {
    initialValue: {
      width: window.innerWidth,
      height: window.innerHeight,
      mode: this.detectDisplayMode(),
      orientation: this.detectDisplayOrientation()
    }
  })

  constructor() {
    fromEvent(window, 'resize')
      .pipe(debounceTime(25), startWith(null))
      .subscribe(() => {
        this.#windowWidth.next(window.innerWidth)
        this.#windowHeight.next(window.innerHeight)
        this.#displayMode.next(this.detectDisplayMode())
        this.#displayOrientation.next(this.detectDisplayOrientation())
      })

    if (this.displayInfo().mode === 'Desktop') this.#menuService.openRightMenu()
    else this.#menuService.closeRightMenu()
  }

  private detectDisplayMode(): DisplayModes {
    const isMobile = /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent) || window.innerWidth < this.MOBILE_BREAKPOINT
    return isMobile ? DisplayModes.Mobile : DisplayModes.Desktop
  }

  private detectDisplayOrientation(): DisplayOrientations {
    if (window.innerWidth > window.innerHeight) return DisplayOrientations.Landscape
    else if (window.innerWidth < window.innerHeight) return DisplayOrientations.Portrait
    else return DisplayOrientations.Square
  }
}