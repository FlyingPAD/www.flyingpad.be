import { Component, effect, input, output } from '@angular/core';
import { Model } from '../../../models/model';
import { MatListModule } from '@angular/material/list';
import { MatIconModule } from '@angular/material/icon';
import { NgxPaginationModule } from 'ngx-pagination';
import { ModelsFilterPipe } from '../../../pipes/models-filter.pipe';

@Component({
  selector: 'app-models-list',
  standalone: true,
  imports: [MatListModule, MatIconModule, NgxPaginationModule, ModelsFilterPipe],
  templateUrl: './models-list.component.html',
  styleUrl: './models-list.component.scss'
})
export class ModelsListComponent 
{
  models = input.required<Model[]>()
  search = input('')
  edit = output<Model>()
  delete = output<number>()
  currentPage : number = 1
  modelsPerPage : number = 12

  constructor() 
  {
    effect(() => console.log(`Nb models : ${this.models().length}`))
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