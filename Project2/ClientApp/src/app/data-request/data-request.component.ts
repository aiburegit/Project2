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
    DeleteCategory(id:number){
        return this.httpClient.get("/Home/DeleteCategory?id="+id)
    }
}