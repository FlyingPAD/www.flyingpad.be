import { Component, Input } from '@angular/core';
import { excludedItemNames } from '../../../data/excluded-item-names';

@Component({
  selector: 'app-bottom-icon-google-image',
  templateUrl: './bottom-icon-google-image.component.html'
})
export class BottomIconGoogleImageComponent {
  @Input() itemName: string | undefined

  private excludedItemNames: string[] = excludedItemNames

  public goToGoogleImages(itemName: string): void {
    const url = `https://images.google.com/images?q=${encodeURIComponent(itemName)}`
    window.open(url, '_blank')
  }

  public showIcon(): boolean {
    return !!this.itemName && !this.excludedItemNames.includes(this.itemName)
  }
}