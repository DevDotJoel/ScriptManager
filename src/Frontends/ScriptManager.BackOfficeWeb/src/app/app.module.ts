import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CreateEditScriptComponent } from './features/script/create-edit-script/create-edit-script.component';
import { ScriptsComponent } from './features/script/scripts/scripts.component';
import { CampaignsComponent } from './features/campaign/campaigns/campaigns.component';
import { LayoutComponent } from './shared/components/layout/layout.component';
import { SpinnerComponent } from './shared/components/spinner/spinner.component';
import { NavbarComponent } from './shared/components/navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateEditScriptComponent,
    ScriptsComponent,
    CampaignsComponent,
    LayoutComponent,
    SpinnerComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
