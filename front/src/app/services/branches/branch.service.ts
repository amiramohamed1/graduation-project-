import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class BranchService {

  private accessPointUrl: string = 'http://localhost:63579/api/branches';
  constructor(private http:HttpClient) { }

  getbranches(id):Observable<any>
  {
       return this.http.get(this.accessPointUrl+"/allbranches/"+id);
  }
}
