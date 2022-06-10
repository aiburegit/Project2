import { Component, OnInit } from '@angular/core';
import { Category } from '../categories/categories.component';
import { DataBaseRequestService } from '../data-request/data-request.component';
import { Unit, UnitsComponent } from '../units/units.component';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor(private database:DataBaseRequestService) { }
  public products:Product[] = [];
  public selectedProduct!:Product | undefined;
  public categories!:Category[];
  public units!:Unit[];
  public key:boolean = true;
 
   ngOnInit(): void {
     this.database.getProducts().subscribe((data:any)=>{
       console.log(data);
       this.products = data;
     });
     this.database.getCategories().subscribe((data:any)=>{
       this.categories = data.$values;
       console.log(this.categories);
     });
     this.database.getUnits().subscribe((data:any)=>{
      this.units = data.$values;
      console.log(this.categories);
    });
   }
   update(){
     this.database.getProducts().subscribe((data:any)=>{
       console.log(data);
       this.products = data;
     });
   }
   Delete(id:number){
     this.database.DeleteProduct(id).subscribe((data)=> {console.log("yes");
     this.update();
   }); 
   }
   Change(){
    console.log();
   }
   Select(id:number , event:Event){ 
     this.key = true;   
     this.selectedProduct = this.products.filter(c => c.id == id)[0];
     console.log(this.selectedProduct);
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
export interface Product{
  productName:string;
  id:number;
  productDescription:string;
  productCount:number;
  productPrice:number;
  priceMultiplicate:number;
  category:Category;
  unit:Unit;
}
