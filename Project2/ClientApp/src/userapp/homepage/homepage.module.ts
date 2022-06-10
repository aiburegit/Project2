import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ScrollpanelComponent } from '../scrollpanel/scrollpanel.component';
import { HomepageComponent } from './homepage.component';



@NgModule({
  declarations: [HomepageComponent , ScrollpanelComponent],
  imports: [
    CommonModule,
  ],
  bootstrap: [HomepageComponent]
})
export class HomePageModule { }