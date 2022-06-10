import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserAppComponent } from './user-app.component';
import { MainpanelComponent } from '../mainpanel/mainpanel.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { HomepageComponent } from '../homepage/homepage.component';
import { RouterModule, Routes } from '@angular/router';
import { ScrollpanelComponent } from '../scrollpanel/scrollpanel.component';
import { HomePageModule } from '../homepage/homepage.module';
import { BrowserModule } from '@angular/platform-browser';
import { CatalogComponent } from '../catalog/catalog.component';
import { ProductlistComponent } from '../productlist/productlist.component';
import { ItemComponent } from '../item/item.component';
import { SelfcabinetComponent } from '../../selfcabinet/selfcabinet.component';


@NgModule({
  declarations: [UserAppComponent , MainpanelComponent,CatalogComponent,ProductlistComponent,ItemComponent,SelfcabinetComponent],
  imports: [
    CommonModule,
    RouterModule,
    HomePageModule
  ],
  bootstrap: [UserAppComponent]
})
export class UserAppModule { }
