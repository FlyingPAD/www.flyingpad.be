import { Component, Input, AfterViewInit } from '@angular/core';

@Component({
  selector: 'app-flip-card',
  templateUrl: './flip-card.component.html',
  styleUrls: ['./flip-card.component.scss']
})
export class FlipCardComponent implements AfterViewInit {
  @Input() cardName!: string;
  @Input() frontImage?: string;

  /** Durée minimale d'affichage du spinner (en ms) */
  @Input() minSpinnerTime = 0;

  frontLoading = true;
  flipped = false;

  private _spinnerStart = 0;

  ngAfterViewInit(): void {
    this._spinnerStart = Date.now();
    if (!this.frontImage) {
      // pas d'image : on retire le spinner puis flip
      this.frontLoading = false;
      setTimeout(() => this.flipped = true, 0);
    }
  }

  onFrontLoad(): void {
    const elapsed = Date.now() - this._spinnerStart;
    const remaining = this.minSpinnerTime - elapsed;

    if (remaining > 0) {
      // on attend le complément, sans désactiver frontLoading
      setTimeout(() => {
        this.frontLoading = false;
        this.flipped = true;
      }, remaining);
    } else {
      // assez attendu, tout de suite
      this.frontLoading = false;
      this.flipped = true;
    }
  }
}