import { Component, OnInit } from '@angular/core';
import { DataBaseRequestService } from '../data-request/data-request.component';

@Component({
  selector: 'app-region',
  templateUrl: './region.component.html',
  styleUrls: ['./region.component.css']
})
export class RegionComponent implements OnInit {

  constructor(private database:DataBaseRequestService) { }
  public regions:Region[] = [];
  public selectedRegion!:Region | undefined;
 
  public key:boolean = true;
 
   ngOnInit(): void {
     this.database.getRegion().subscribe((data:any)=>{
       console.log(data);
       this.regions =  data.$values;
     });
   }
   update(){
     this.database.getRegion().subscribe((data:any)=>{
       console.log(data);
       this.regions =  data.$values;
     });
   }
   Delete(id:number){
     this.database.DeleteRegion(id).subscribe((data)=> {console.log("yes");
     this.update();
   }); 
   }
   Change(){
    console.log();
   }
   Select(id:number , event:Event){ 
     this.key = true;   
     this.selectedRegion = this.regions.filter(c => c.id == id)[0];
     console.log(this.selectedRegion);
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
export interface Region{
  regionName:string;
  id:number;
}
