import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './shared/components/layout/layout.component';
import { ScriptsComponent } from './features/script/scripts/scripts.component';
import { CampaignsComponent } from './features/campaign/campaigns/campaigns.component';
import { CreateEditScriptComponent } from './features/script/create-edit-script/create-edit-script.component';

const routes: Routes = [
  {path: '', component: LayoutComponent,
  children: [
            {path: 'scripts', component: ScriptsComponent},
            {path: 'scripts/:id', component: CreateEditScriptComponent},
            {path: 'campaigns', component: CampaignsComponent},
            ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
