import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HatComponent } from './hat/hat.component';

import { HatsService } from './hats.service';

@NgModule({
  declarations: [
    AppComponent,
    HatComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [HatsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
