import { inject, Injectable, Injector, Type } from '@angular/core';
import { Overlay, OverlayConfig, OverlayRef } from '@angular/cdk/overlay';
import { ComponentPortal } from '@angular/cdk/portal';
import { merge, EMPTY, Observable } from 'rxjs';
import { map, take, tap } from 'rxjs/operators';
import { OverlayHandle } from '../interfaces/overlay-handle';

@Injectable({ providedIn: 'root' })
export class OverlayService {
  #overlay = inject(Overlay)
  #injector = inject(Injector)

  public open<T extends object>(component: Type<T>, data: Partial<T> = {}): OverlayHandle<T> {
    const config = new OverlayConfig({
      hasBackdrop: true,
      backdropClass: 'cdk-overlay-dark-backdrop',
      panelClass: ['centered-overlay'],
      scrollStrategy: this.#overlay.scrollStrategies.block(),
      positionStrategy: this.#overlay.position()
        .global()
        .centerHorizontally()
        .centerVertically()
    });
    const overlayRef: OverlayRef = this.#overlay.create(config)

    const portal = new ComponentPortal(component, null, this.#injector)
    const cmpRef = overlayRef.attach(portal)

    Object.assign(cmpRef.instance, data as T)

    const backdropClick$: Observable<void> = overlayRef.backdropClick().pipe(map(() => undefined))

    const closeEmitter$ = (cmpRef.instance as any).close
      ? ((cmpRef.instance as any).close as Observable<unknown>).pipe(map(() => undefined))
      : EMPTY

    const closed$: Observable<void> = merge(backdropClick$, closeEmitter$).pipe(
      take(1),
      tap(() => overlayRef.dispose())
    )

    return {
      instance: cmpRef.instance,
      closed$,
      close: () => overlayRef.dispose()
    }
  }
}