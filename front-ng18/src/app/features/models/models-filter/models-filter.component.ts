import { Component, effect, output, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-models-filter',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './models-filter.component.html',
  styleUrl: './models-filter.component.scss'
})
export class ModelsFilterComponent {
  search = output<string>();
  value = signal<string>('');

  constructor() {
    effect(() => this.search.emit(this.value()))
  }
}
