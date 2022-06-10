import { Component, OnInit } from '@angular/core';

import { DataBaseRequestService } from '../data-request/data-request.component';

@Component({
  selector: 'app-units',
  templateUrl: './units.component.html',
  styleUrls: ['./units.component.css']
})
export class UnitsComponent implements OnInit {

  
  constructor(private database:DataBaseRequestService) { }
 public units:Unit[] = [];
 public selectedUnit!:Unit | undefined;

 public key:boolean = true;

  ngOnInit(): void {
    this.database.getUnits().subscribe((data:any)=>{
      console.log(data);
      this.units =  data.$values;
    });
  }
  update(){
    this.database.getUnits().subscribe((data:any)=>{
      console.log(data);
      this.units =  data.$values;
    });
  }
  Delete(id:number){
    this.database.DeleteUnits(id).subscribe((data)=> {console.log("yes");
    this.update();
  }); 
  }
  Change(){
   console.log();
  }
  Select(id:number , event:Event){ 
    this.key = true;   
    this.selectedUnit = this.units.filter(c => c.id == id)[0];
    console.log(this.selectedUnit);
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

export interface Unit{
  id:number;
  unitName:String;
}
