import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { toSignal } from '@angular/core/rxjs-interop';
import screenfull from 'screenfull';

@Injectable({
  providedIn: 'root'
})
export class FullScreenService {
  private readonly DEFAULT_FULLSCREEN_STATE = false
  #isFullscreen = new BehaviorSubject<boolean>(this.DEFAULT_FULLSCREEN_STATE)
  public isFullscreen = toSignal(this.#isFullscreen)

  async toggleFullscreen(): Promise<void> {
    if (screenfull.isEnabled) {
      await screenfull.toggle()
      this.#isFullscreen.next(screenfull.isFullscreen)
    } else {
      this.#isFullscreen.next(this.DEFAULT_FULLSCREEN_STATE)
    }
  }

  async enterFullscreen(): Promise<void> {
    if (screenfull.isEnabled) {
      await screenfull.request()
      this.#isFullscreen.next(true)
    } else {
      this.#isFullscreen.next(this.DEFAULT_FULLSCREEN_STATE)
    }
  }

  async exitFullscreen(): Promise<void> {
    if (screenfull.isEnabled && screenfull.isFullscreen) {
      await screenfull.exit()
      this.#isFullscreen.next(false)
    } else {
      this.#isFullscreen.next(this.DEFAULT_FULLSCREEN_STATE)
    }
  }
}