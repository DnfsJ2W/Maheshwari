
import { BrowserModule } from '@angular/platform-browser';  
import { NgModule } from '@angular/core';  
import { FormsModule, ReactiveFormsModule } from '@angular/forms';  
import { AppComponent } from './app.component';  
import { HttpClientModule } from '@angular/common/http';  
//import { TrackbyComponent } from './trackby/trackby.component';  
import { ObservableExampleComponent } from './observable-example/observable-example.component'; 
import { PromiseExampleComponent } from './promise-example/promise-example.component';  
import { CountryService } from './country.service';  
@NgModule({  
  declarations: [  
    AppComponent, 
   // TrackbyComponent, 
    ObservableExampleComponent,  
    PromiseExampleComponent  
  ],  
  imports: [  
    BrowserModule,  
    FormsModule,  
    ReactiveFormsModule, 
    HttpClientModule  
  ],  
  providers: [CountryService],  
  bootstrap: [AppComponent]  
})  
export class AppModule { }