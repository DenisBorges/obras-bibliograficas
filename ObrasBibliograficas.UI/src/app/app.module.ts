import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AutorListComponent } from './autor-list/autor-list.component';
import { AutorAddComponent } from './autor-add/autor-add.component';
import { SlimLoadingBarModule } from 'ng2-slim-loading-bar';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AutorService } from './services/autor.service';

@NgModule({
  declarations: [
    AppComponent,
    AutorListComponent,
    AutorAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SlimLoadingBarModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [AutorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
