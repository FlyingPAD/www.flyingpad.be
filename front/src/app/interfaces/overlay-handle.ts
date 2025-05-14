import { Observable } from "rxjs";

export interface OverlayHandle<T> {
  instance: T
  closed$: Observable<void>
  close: () => void
}