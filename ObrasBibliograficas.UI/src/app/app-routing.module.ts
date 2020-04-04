import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AutorListComponent } from './autor-list/autor-list.component';
import { AutorAddComponent } from './autor-add/autor-add.component';

const routes: Routes = [  {
  path: 'autor',
  component: AutorListComponent,
  data: { title: 'Lista de Autores' }
},
{
  path: 'autor/create',
  component: AutorAddComponent,
  data: { title: 'Adicionar Autor' }
},
{ path: '',
  redirectTo: '/autor',
  pathMatch: 'full'
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
