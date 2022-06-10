import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppModule } from 'src/app/app.module';
import { UserAppModule } from 'src/userapp/user-app/user-app.module';
import { AppComponent } from 'src/app/app.component';
import { UserAppComponent } from 'src/userapp/user-app/user-app.component';
import { RouterModule, Routes } from '@angular/router';
import { MainAppComponent } from './main-app/main-app.component';
import { AdministrationComponent } from 'src/app/administration/administration.component';
import { CustomersComponent } from 'src/app/customers/customers.component';
import { ProductComponent } from 'src/app/product/product.component';
import { OrderComponent } from 'src/app/order/order.component';
import { HomepageComponent } from 'src/userapp/homepage/homepage.component';
import { ScrollpanelComponent } from 'src/userapp/scrollpanel/scrollpanel.component';
import { CatalogComponent } from 'src/userapp/catalog/catalog.component';
import { BrowserModule } from '@angular/platform-browser';
import { ProductlistComponent } from 'src/userapp/productlist/productlist.component';
import { ItemComponent } from 'src/userapp/item/item.component';
import { SelfcabinetComponent } from 'src/selfcabinet/selfcabinet.component';
import { LoginComponent } from 'src/login/login.component';
import { RegisterComponent } from 'src/register/register.component';


const itemRoutes: Routes = [
  { path: 'admin-panel', component: AdministrationComponent },
  { path: 'customers', component: CustomersComponent},
  { path: 'products', component: ProductComponent},
  { path: 'orders', component: OrderComponent},
  
];
const itemRoute =[
  {path: 'home' , component: HomepageComponent},
  {path: 'catalog' , component: CatalogComponent},
  {path: 'productlist' , component: ProductlistComponent},
  {path: 'item' , component: ItemComponent},
  {path: 'cabinet' , component: SelfcabinetComponent}
]

@NgModule({
  declarations: [MainAppComponent],
  imports: [
    CommonModule,
    BrowserModule,
    AppModule,
    UserAppModule,
    RouterModule.forRoot([
      {path:'usr' , component: UserAppComponent , children:itemRoute},
      {path: 'admin' , component: AppComponent , children:itemRoutes},
      {path: 'login' , component: LoginComponent },
      {path: 'register' , component: RegisterComponent},
      
    ])
  ],
  bootstrap: [MainAppComponent]
})
export class ModuleModule { }
