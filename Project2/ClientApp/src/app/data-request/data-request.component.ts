import { HttpClient } from '@angular/common/http';
import { Component, Inject, Injectable, OnInit } from '@angular/core';

@Injectable()
export class DataBaseRequestService implements OnInit{
    constructor( readonly httpClient:HttpClient){}
    ngOnInit(){

    }
    getCategories(){
     return this.httpClient.get("/Home/GetCategories");
    }
    getUnits(){
        return this.httpClient.get("/Home/GetUnits");
    }
    DeleteUnits(id:number){
        return this.httpClient.get("/Home/DeleteUnit?id="+id);
    }
    DeleteCategory(id:number){
        return this.httpClient.get("/Home/DeleteCategory?id="+id)
    }
    getRegion(){
        return this.httpClient.get("/Home/GetRegions");
    }
    DeleteRegion(id:number){
        return this.httpClient.get("/Home/DeleteRegion?id="+id);
    }
    getCustomers(){
        return this.httpClient.get("/Home/GetCustomers");
    }
    DeleteCustomer(id:number){
        return this.httpClient.get("/Home/DeleteCustomer?id="+id);
    }
    getProducts(){
        return this.httpClient.get("/Home/GetProducts");
    }
    DeleteProduct(id:number){
        return this.httpClient.get("/Home/DeleteProduct?id="+id);
    }
    Register(login:string , password:string , name:string){
        const param = {login:login , password:password , name:name};
        return this.httpClient.post("/Account/Register",param);
    }
    Login(login:string , password:string){
        const param = {login:login , password:password};
        return this.httpClient.post("/Account/Login",param);
    }

}