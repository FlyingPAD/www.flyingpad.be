import { CommonModule } from '@angular/common';
import { Component, effect, output, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-link-filter',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './link-filter.component.html',
  styleUrl: './link-filter.component.scss'
})
export class LinkFilterComponent {
  search = output<string>();
  value = signal<string>('');

  constructor() {
    effect(() => this.search.emit(this.value()))
  }
}
