import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class RequestService {

  private accessPointUrl: string = 'http://localhost:63579/api/Request';
  constructor(private http:HttpClient) { }

  getuserRequest(id):Observable<any>
  {
     return this.http.get(this.accessPointUrl+"/user/"+id);
  }

  getstatus(id):Observable<any>
  {
    return this.http.get(this.accessPointUrl+"/type/"+id);
  }
  
  changestatus(id):Observable<any>
  {
    return this.http.get(this.accessPointUrl+"/status/"+id);
  }

  counter(id,uid):Observable<any>
  {
    return this.http.get(this.accessPointUrl+"/notification/"+id+"/"+uid);
  }

}
