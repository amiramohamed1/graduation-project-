import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './admin/profile/profile.component';
import { LogComponent } from './log/log.component';
import { EnteryComponent } from './entery/entery.component';


const routes: Routes = [
  {path:'',component:EnteryComponent},
  {path:'profile',component:ProfileComponent},
  {path:'signin',component:LogComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
