import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { User } from 'src/app/Models/user/user';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class UserService {
  
  private accessPointUrl: string = 'http://localhost:63579/api/user';
  constructor(private http:HttpClient) { }

  addrecord(user:User):Observable<any>
  {
      return this.http.post(this.accessPointUrl+"/users",user);
  }
  
  getuser(username,password):Observable<any>
  {
    return this.http.get(this.accessPointUrl+"/log/"+username+"/"+password);
  }

}
