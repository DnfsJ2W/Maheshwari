import { Component, OnInit } from '@angular/core';
import { CountryService } from '../country.service';  
import { FormControl } from '@angular/forms'; 
//import 'rxjs/add/operator/debounceTime';  
//import 'rxjs/add/operator/distinctUntilChanged';  

@Component({
  selector: 'app-observable-example',
  templateUrl: './observable-example.component.html',
  styleUrls: ['./observable-example.component.css']
})
export class ObservableExampleComponent implements OnInit {

  country: any;  
    constructor(private _countryService:CountryService) { }  
    public term =new FormControl();  
    ngOnInit() {  
      this.term.valueChanges  
      //.debounceTime(400)  
      //.distinctUntilChanged() 
      .subscribe(searchText=>{  
        this._countryService.getSearchedCountry(searchText).subscribe((result)=>{ 
          console.log(result);  
          this.country =result; 
        }) 
      })  
    }  
  } 


