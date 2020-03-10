import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AlmacenesComponent } from './Almacenes/Almacenes.component';
import { AnexosComponent } from './Anexos/anexos.componet'

import { AlmacenesFormComponent } from './Almacenes/Almacenes-form/almacenes-form.component';
import { Service } from './Services/anexos.service';

@NgModule({ 
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent, 
    FetchDataComponent,    
    AlmacenesComponent,
    AnexosComponent,
    AlmacenesFormComponent
   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
     { path: 'almacenes', component: AlmacenesComponent },
     { path: 'almacenes-agregar', component: AlmacenesFormComponent },
     { path: 'almacenes-agregar', component: AnexosComponent }
    ])
  ],
  providers: [AlmacenService],
   bootstrap: [AppComponent]
})
export class AppModule { }
