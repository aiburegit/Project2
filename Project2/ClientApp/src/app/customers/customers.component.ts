import { Component, OnInit } from '@angular/core';
import { DataBaseRequestService } from '../data-request/data-request.component';
import { Region } from '../region/region.component';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  constructor(private database:DataBaseRequestService) { }
  public customers:Customer[] = [];
  public selectedCustomer!:Customer | undefined;
 
  public key:boolean = true;
 
   ngOnInit(): void {
     this.database.getCustomers().subscribe((data:any)=>{
       console.log(data);
       this.customers = data;
     });
   }
   update(){
     this.database.getCustomers().subscribe((data:any)=>{
       console.log(data);
       this.customers = data;
     });
   }
   Delete(id:number){
     this.database.DeleteCustomer(id).subscribe((data)=> {console.log("yes");
     this.update();
   }); 
   }
   Change(){
    console.log();
   }
   Select(id:number , event:Event){ 
     this.key = true;   
     this.selectedCustomer = this.customers.filter(c => c.id == id)[0];
     console.log(this.selectedCustomer);
     let elem = <HTMLElement>event.target;
     let parent = elem.parentElement;
     console.log(elem.parentElement);
     if(parent!= null)
     parent.style.backgroundColor = "grey";
   }
   ClosePanel(){
     this.key = false;
   }
   Show(){
    this.key = true;
   }
 

}
export interface Customer{
  customerName:string;
  id:number;
  customerPhone:string;
  customerRegion:Region;
  
}
