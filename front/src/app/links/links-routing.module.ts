import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './components/list/list.component';

const routes: Routes = 
[
  { path : '', pathMatch : 'full', redirectTo : 'list'},
  { path : 'list', component : ListComponent, title : 'Flying PAD | Links' },
  { path : 'list/:id', component : ListComponent, title : 'Flying PAD | Links' },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LinksRoutingModule { }
