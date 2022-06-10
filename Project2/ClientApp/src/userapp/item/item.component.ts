import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent implements OnInit {

  Stats:Stats[] = [{name:"Потребляемая мощность" , value:"1200w"},{name:"Мощность всасывания" , value:"350w"},{name:"Тип бака" , value:"Сменный бачок"},{name:"Уровень шума" , value:"Средний"}]
  constructor() { }

  ngOnInit(): void {
  }

}
            

export interface Stats{
  name:string;
  value:string;
}