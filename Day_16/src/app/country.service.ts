import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  employees: any[];  
 private url = '';  
  private baseUrl = "https://localhost:44328/";//Replace it with your http address and port  
  constructor(public http: HttpClient) {  
  }  
  getSearchedCountry(keyWord) {  
    this.url = this.baseUrl + 'api/Country/getSearchedCountry/'+keyWord;  
    return this.http.get<any[]>(this.url);  
  } 
}
