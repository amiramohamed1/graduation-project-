import { Component, OnInit,Input,Output,EventEmitter } from '@angular/core';
import { variable } from '@angular/compiler/src/output/output_ast';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { User } from '../Models/user/user';
import { UserService } from '../services/user/user.service';
import { Branch } from '../Models/branches/branch';
import { BranchService } from '../services/branches/branch.service';
import { Router } from '@angular/router';
import { state } from '@angular/animations';
@Component({
  selector: 'app-log',
  templateUrl: './log.component.html',
  styleUrls: ['./log.component.css']
})
export class LogComponent implements OnInit {
  public Ana:User=new User();
  public aya:User = new User();
  public amira:Branch[];
  public id:number;
  branches()
  {
    this.servicebranch.getbranches(3).subscribe(a=>
      {this.amira=a;
        console.log(a); 
      });
  }

  mybranch(idbranch)
  {
    var x:number=+idbranch
    this.id=x;
    console.log(idbranch);
  }
  userform:FormGroup
  usersignin:FormGroup
  get name()
  {
    return this.usersignin.get('name');
  }
  get pass()
  {
    return this.usersignin.get('pass');
  }
  get username()
  {
    return this.userform.get('username');
  }

  get password()
  {
    return this.userform.get('password');
  }

  get Email()
  {
    return this.userform.get('Email');
  }

  get Address()
  {
    return this.userform.get('Address');
  }

  get ssn()
  {
    return this.userform.get('ssn');
  }

  get phone()
  {
    return this.userform.get('phone');
  }

  get branchId()
  {
    return this.userform.get('branchId');
  }
  constructor(private srviceuser:UserService,private servicebranch:BranchService,private _route:Router) { 
    this.branches();
  }

  ngOnInit() {
    this.userform=new FormGroup({
      username:new FormControl('',[Validators.required,Validators.minLength(3)]),
      password:new FormControl('',[Validators.required,Validators.minLength(6)]),
      Email:new FormControl('',[Validators.required,Validators.email]),
      Address:new FormControl('',Validators.required),
      ssn:new FormControl('',[Validators.required,Validators.pattern("[0-9]{14}")]),
      phone:new FormControl('',[Validators.required,Validators.pattern("[0-9]{11}")]),
      branchId:new FormControl('',Validators.required)
    })

    this.usersignin=new FormGroup({
      name:new FormControl('',Validators.required),
      pass:new FormControl('',Validators.required)
    })
  }

  register()
  {
    if(this.userform.valid)
    {
      this.aya.branchId=this.id;
      this.srviceuser.addrecord(this.aya).subscribe(a=>{
        console.log(a);
        if(a==null)
        {
          alert("UserName is Not Valid");
        }
        else
        {
          this.userform.reset();
          alert("Please Login");
        }
      
       });
    }
     else
     {
       alert("Please Enter Your Data");
     }
  }


 login()
  {
    if(this.usersignin.valid)
    {
      this.srviceuser.getuser(this.Ana.name,this.Ana.password).subscribe(a=>{
        this.Ana=a;
        if(a==null)
        {
          this.usersignin.reset();
          alert("You Are Not A User Please SignUp");
        }
        else
        {
          this._route.navigate(['profile'],{state:{me:this.Ana}});
        }
      })
    }
    else
    {
      alert("Please Enter Your Data");
    }
    
  }
}
