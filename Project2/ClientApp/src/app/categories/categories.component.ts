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
  ngOnInit(): void {
    this.database.getCategories().subscribe((data:any)=>{
      console.log(data);
      this.categories = data;
    });
  }
  update(){
    this.database.getCategories().subscribe((data:any)=>{
      console.log(data);
      this.categories = data;
    });
  }
  Delete(id:number){
    this.database.DeleteCategory(id).subscribe((data)=> {console.log("yes");
    this.update();
  });
    
  }

}
interface Category{
  id:number
  categoryName:string
  categoryDescription:string
}
