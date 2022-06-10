import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-scrollpanel',
  templateUrl: './scrollpanel.component.html',
  styleUrls: ['./scrollpanel.component.css']
})
export class ScrollpanelComponent implements OnInit {

  ScrollElements:ScrollElement[] = [{name:"cake",price:"100"} ,{name:"car",price:"100"},{name:"lizard",price:"100"},{name:"squid",price:"100"},
                                    {name:"cake",price:"100"} ,{name:"car",price:"100"},{name:"lizard",price:"100"},{name:"squid",price:"100"}];
  constructor() { }

  ngOnInit(): void {
  }
  left(){
    let elem = document.getElementsByClassName("elements")[0] as HTMLDivElement;
    let scrolState:number = elem.scrollLeft;
    elem.scrollTo(scrolState - 50 , 0);
    
    console.log(elem);
  }
  right(){
    let elem = document.getElementsByClassName("elements")[0] as HTMLDivElement;
    let scrolState:number = elem.scrollLeft;
    elem.scrollTo(scrolState + 50 , 0);
    
    console.log(scrolState);
  }

}
export interface ScrollElement{
  name:string;
  price:string;
}
