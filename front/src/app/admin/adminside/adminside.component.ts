import { Component, OnInit,Input } from '@angular/core';
import { User } from 'src/app/Models/user/user';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { RequestService } from 'src/app/services/Requests/request.service';

@Component({
  selector: 'app-adminside',
  templateUrl: './adminside.component.html',
  styleUrls: ['./adminside.component.css']
})
export class AdminsideComponent implements OnInit {
 public m:User;
 public u:Request[];
 btnstyle:string;
 type:boolean;
 public count:number;
 Requests()
 {
   this.requestservice.getuserRequest(this.m.id).subscribe(a=>{
     this.u=a;
   })
 }


 checked(id)
 {
     this.requestservice.changestatus(id).subscribe(a=>{
       this.Requests();
       console.log(a);
     });
     console.log(id);
      
 }


 counts()
 {
  this.requestservice.counter(3,this.m.id).subscribe(a=>{
    this.count=a;
  })
 }

 
  constructor(private _route:Router,private requestservice:RequestService) { 
       this.m=this._route.getCurrentNavigation().extras.state.me;
       this.Requests();
       this.counts();
  }
   
  ngOnInit() {

    setInterval(()=>{
      this.counts();
      this.Requests();
      this.checked;
     },1000);
 
  }

}
