import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  Categories:CategoryType[] = [
    {Categories: [{ Name: "Стиральная машина" , PhotoUrl:"../../assets/images/wood.png"} ,{ Name: "Холодильник", PhotoUrl:"../../assets/images/wood.png" },{ Name: "Пылесос", PhotoUrl:"../../assets/images/wood.png" },{ Name: "Стиральная машина" , PhotoUrl:"../../assets/images/wood.png"} ,{ Name: "Холодильник", PhotoUrl:"../../assets/images/wood.png" },{ Name: "Пылесос", PhotoUrl:"../../assets/images/wood.png" } ], TypeName: "Электроника"},
    {Categories: [{ Name: "Брус", PhotoUrl:"../../assets/images/wood.png" } ,{ Name: "Кирпич", PhotoUrl:"../../assets/images/wood.png" },{ Name: "Плитка", PhotoUrl:"../../assets/images/wood.png" } ], TypeName: "Стройматериалы"},
    {Categories: [{ Name: "Обувь", PhotoUrl:"../../assets/images/wood.png" } ,{ Name: "Худи", PhotoUrl:"../../assets/images/wood.png" },{ Name: "Костюм", PhotoUrl:"../../assets/images/wood.png" } ], TypeName: "Одежда"}
  ];
  constructor() { }

  ngOnInit(): void {
  }


}
export interface CategoryType{
Categories:Category[];
TypeName:string;
}
export interface Category{
Name:string;
PhotoUrl:string;
}