import { Component, OnInit } from '@angular/core';
declare var $: any;
@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent implements OnInit {

  Items:Items[] = [{Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (1).png"},
                  {Name: "Samsung" , Price: "12000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (2).png"},
                  {Name: "Kerel" , Price: "10000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "TurboPower" , Price: "14500" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (4).png"},
                  {Name: "Unicorn" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (5).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (6).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (1).png"},
                  {Name: "Samsung" , Price: "12000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (2).png"},
                  {Name: "Kerel" , Price: "10000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "TurboPower" , Price: "14500" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (4).png"},
                  {Name: "Unicorn" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (5).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (6).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (1).png"},
                  {Name: "Samsung" , Price: "12000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (2).png"},
                  {Name: "Kerel" , Price: "10000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (3).png"},
                  {Name: "TurboPower" , Price: "14500" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (4).png"},
                  {Name: "Unicorn" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (5).png"},
                  {Name: "Bosh" , Price: "13000" , Unit: "шт" , ImageUrl: "../../assets/images/pngegg (6).png"}];

    Params:Params[] = [{Power:["1000w","1200w","1500w","2000w"] , SuctionPower:["250w", "350w","450W"] , TankType:["Сменный бачок","Двойной фильтр"] , NoiseLvl:["Тихий","Средний","Шумный"]}];              

  constructor() { }

  ngOnInit(): void {
   this.scrollInit();
  }
  scrollInit(){
    $( function() {
      $( "#slider-range").slider({
        range: true,
        min: 0,
        max: 9999,
        values: [ 0, 5000 ],
        slide: function( event:any, ui:any ) {
          $("#ot").text(  ui.values[ 0 ]+'p');
          $("#do").text(  ui.values[ 1 ]+'p');
          
        }
      });
      
      $( "#amount" ).val( "$" + (<any> $( "#slider-range")).slider( "values", 0 ) +
        " - $" + (<any> $( "#slider-range")).slider( "values", 1 ) );

        
    } );
  }

}
export interface Items{
  Name:string;
  Price:string;
  ImageUrl:string;
  Unit:string;  
}
export interface Params{
  Power:string[];
  SuctionPower:string[];
  TankType:string[];
  NoiseLvl:string[];
}
export interface Manufacturers{
  Name:string;
}
