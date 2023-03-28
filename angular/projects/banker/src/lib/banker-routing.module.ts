import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BankerComponent } from './components/banker.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: BankerComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class BankerRoutingModule {}
