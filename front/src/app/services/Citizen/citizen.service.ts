import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CitizenService {

  private accessPointUrl: string = 'http://localhost:63579/api/citizen';
  constructor(private http:HttpClient) { }

  getcitizen(id):Observable<any>
  {
    return this.http.get(this.accessPointUrl+"/"+id);
  }
}
