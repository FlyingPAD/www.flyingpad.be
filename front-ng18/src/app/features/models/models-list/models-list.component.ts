import { Component, effect, input, output } from '@angular/core';
import { Model } from '../../../models/models';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-models-list',
  standalone: true,
  imports: [MatListModule, MatIconModule],
  templateUrl: './models-list.component.html',
  styleUrl: './models-list.component.scss'
})
export class ModelsListComponent 
{
  models = input.required<Model[]>()
  search = input('')
  edit = output<Model>()
  delete = output<number>()

  constructor() 
  {
    effect(() => console.log(`Nb links: ${this.models().length}`))
  }

  handleEdit(model: Model) 
  {
    this.edit.emit(model)
  }

  handleDelete(id: number) 
  {
    this.delete.emit(id)
  }
}