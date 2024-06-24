import { Component, inject, input, signal } from '@angular/core';
import { ModelsListComponent } from '../../features/models/models-list/models-list.component';
import { ActivatedRoute, Router } from '@angular/router';
import { toSignal } from '@angular/core/rxjs-interop';
import { map } from 'rxjs';
import { ModelsFilterComponent } from '../../features/models/models-filter/models-filter.component';
import { Model, ModelForm } from '../../models/model';
import { ModelsEditionService } from '../../services/models-edition.service';
import { ModelsDialogComponent } from '../../features/models/models-dialog/models-dialog.component';
import { ModelsFormComponent } from '../../features/models/models-form/models-form.component';

@Component({
  selector: 'app-models',
  standalone: true,
  imports: [ModelsListComponent, ModelsFilterComponent, ModelsDialogComponent, ModelsFormComponent],
  templateUrl: './models.component.html',
  styleUrl: './models.component.scss'
})
export class ModelsComponent 
{

  #activatedRoute = inject(ActivatedRoute);
  #router = inject(Router);
  #modelsService = inject(ModelsEditionService)
  categories = input<Model[]>([]);
  isOpen = signal(false);
  search = signal('');

  
  models = toSignal(this.#activatedRoute.data.pipe(
    map( (data : any) => data['models']) 
  ))

  handleEdit(model: Model) {
    this.isOpen.set(true);
  }

  handleDelete(id: number) {
    this.#modelsService.delete(id).subscribe(() => this.reload());
  }
  handleSave(linkForm: ModelForm) {
    this.resetDialog();
    this.#modelsService.createOrUpdate(linkForm).subscribe(() => this.reload());
  }

  handleCloseDialog() {
    this.resetDialog();
  }

  handleSearch(value: string) {
    this.search.set(value)
  }

  toggleDialog() {
    this.isOpen.update(x => !x);
  }

  private resetDialog() {
    this.isOpen.set(false);
  }

  private reload() {
    const { pathname, search } = window.location;
    const currentUrl = `${pathname}${search}`;
    this.#router.navigateByUrl(currentUrl)
  }
}
