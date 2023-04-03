import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CreateEditScriptComponent } from './features/script/create-edit-script/create-edit-script.component';
import { ScriptsComponent } from './features/script/scripts/scripts.component';
import { CampaignsComponent } from './features/campaign/campaigns/campaigns.component';
import { LayoutComponent } from './shared/components/layout/layout.component';
import { SpinnerComponent } from './shared/components/spinner/spinner.component';
import { NavbarComponent } from './shared/components/navbar/navbar.component';
import { ScriptListComponent } from './features/script/components/script-list/script-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatButtonModule} from '@angular/material/button';
import {MatTableModule} from '@angular/material/table';
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
@NgModule({
  declarations: [
    AppComponent,
    CreateEditScriptComponent,
    ScriptsComponent,
    CampaignsComponent,
    LayoutComponent,
    SpinnerComponent,
    NavbarComponent,
    ScriptListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatTableModule,
    MatCardModule,
    MatInputModule,
    FormsModule,
    MatProgressSpinnerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
