import { Component, OnInit } from '@angular/core';
import { DataBaseRequestService } from '../data-request/data-request.component';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

constructor(private database:DataBaseRequestService) { }
 public categories:Category[] = [];
 public selectedCetegory!:Category | undefined;

 public key:boolean = true;

  ngOnInit(): void {
    this.database.getCategories().subscribe((data:any)=>{
      console.log(data);
      this.categories =  data;
      console.log(this.categories);
    });
  }
  update(){
    this.database.getCategories().subscribe((data:any)=>{
      console.log(data);
      this.categories = data.$values;
    });
  }
  Delete(id:number){
    this.database.DeleteCategory(id).subscribe((data)=> {console.log("yes");
    this.update();
  }); 
  }
  Change(){
   console.log();
  }
  Select(id:number , event:Event){ 
    this.key = true;   
    this.selectedCetegory = this.categories.filter(c => c.id == id)[0];
    console.log(this.selectedCetegory);
    let elem = <HTMLElement>event.target;
    let parent = elem.parentElement;
    console.log(elem.parentElement);
    if(parent!= null)
    parent.style.backgroundColor = "grey";
  }
  ClosePanel(){
    this.key = false;
  }

}
export interface Category{
  id:number
  categoryName:string
  categoryDescription:string
}
