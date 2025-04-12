import { Component, Input } from '@angular/core';
import { excludedItemNames } from '../../../data/excluded-item-names';

@Component({
  selector: 'app-bottom-icon-google',
  templateUrl: './bottom-icon-google.component.html'
})
export class BottomIconGoogleComponent {
  @Input() itemName: string | undefined

  private excludedItemNames: string[] = excludedItemNames

  public goToGoogleSearch(itemName: string): void {
    const url = `https://www.google.com/search?q=${encodeURIComponent(itemName)}`;
    window.open(url, '_blank')
  }

  public showIcon(): boolean {
    return !!this.itemName && !this.excludedItemNames.includes(this.itemName)
  }
}