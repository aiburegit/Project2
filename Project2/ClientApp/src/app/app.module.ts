import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';

import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AdministrationComponent } from './administration/administration.component';
import { CustomersComponent } from './customers/customers.component';
import { ProductComponent } from './product/product.component';
import { OrderComponent } from './order/order.component';
import { UnitsComponent } from './units/units.component';
import { CategoriesComponent } from './categories/categories.component';
import { DataBaseRequestService } from './data-request/data-request.component';
import { RegionComponent } from './region/region.component';



const itemRoutes: Routes = [
  { path: 'categories', component: CategoriesComponent},
  { path: 'units', component: UnitsComponent},
  {path: 'regions', component: RegionComponent}
];
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FetchDataComponent,
    AdministrationComponent,
    CustomersComponent,
    ProductComponent,
    OrderComponent,
    UnitsComponent,
    CategoriesComponent,
    RegionComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'fetch-data', component: FetchDataComponent },
      {path: 'admin-panel' , component: AdministrationComponent , children:itemRoutes},
      {path: 'customers' , component: CustomersComponent},
      {path: 'products' , component: ProductComponent},
      {path: 'orders' , component: OrderComponent},
    ])
  ],
  providers: [DataBaseRequestService],
  bootstrap: [AppComponent]
})
export class AppModule { }
