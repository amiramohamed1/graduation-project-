import { Component, OnInit } from '@angular/core';
import { RequestService } from '../services/Requests/request.service';
import { User } from '../Models/user/user';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  public count:number;
  public m:User;
  constructor(private requestservice:RequestService,private _route:Router) { 
    this.m=this._route.getCurrentNavigation().extras.state.me;
    this.counts();
  }
  counts()
  {
   this.requestservice.counter(3,this.m.id).subscribe(a=>{
     this.count=a;
   })
  }

  ngOnInit() {

    setInterval(()=>{
     this.counts();
    },10);


  }

}
