import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ButtonBackComponent } from './components/button-back/button-back.component';
import { CurrentTimeComponent } from './components/current-time/current-time.component';
import { MenuLeftDesktopComponent } from './components/menu-left-desktop/menu-left-desktop.component';
import { MenuRightDesktopComponent } from './components/menu-right-desktop/menu-right-desktop.component';
import { MenuRightMobileComponent } from './components/menu-right-mobile/menu-right-mobile.component';
import { MenuTriggerLeftComponent } from './components/menu-trigger-left/menu-trigger-left.component';
import { MenuTriggerRightComponent } from './components/menu-trigger-right/menu-trigger-right.component';
import { MenuLeftMobileComponent } from './components/menu-left-mobile/menu-left-mobile.component';
import { RouterModule } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';
import { CommonModule } from '@angular/common';
import { FormatDurationPipe } from './pipes/format-duration.pipe';
import { FormatSizePipe } from './pipes/format-size.pipe';
import { PanelCrudDesktopComponent } from './components/panel-crud-desktop/panel-crud-desktop.component';
import { PanelCrudMobileComponent } from './components/panel-crud-mobile/panel-crud-mobile.component';
import { MenuTriggerLeftInfoComponent } from './components/menu-trigger-left-info/menu-trigger-left-info.component';
import { MenuTriggerRightSearchComponent } from './components/menu-trigger-right-search/menu-trigger-right-search.component';
import { MenuTriggerRightFilterComponent } from './components/menu-trigger-right-filter/menu-trigger-right-filter.component';
import { ButtonTopComponent } from './components/button-top/button-top.component';

@NgModule({
  declarations: 
  [
    // Components :

    CurrentTimeComponent,
    ButtonBackComponent,
    ButtonTopComponent,

    MenuLeftDesktopComponent,
    MenuRightDesktopComponent,
    MenuLeftMobileComponent,
    MenuRightMobileComponent,

    MenuTriggerLeftComponent,
    MenuTriggerRightComponent,
    MenuTriggerLeftInfoComponent,
    MenuTriggerRightSearchComponent,
    MenuTriggerRightFilterComponent,

    PanelCrudDesktopComponent,
    PanelCrudMobileComponent,

    // Pipes :

    FormatDurationPipe,
    FormatSizePipe,
  ],
  imports: 
  [
    CommonModule,
    RouterModule,                // RouterLink
    ReactiveFormsModule,         // Form Use ( ngModel, ... )
    FormsModule,                 // Form Use ( onSubmit, ... )
    NgxPaginationModule,         // NGX Pagination Module
  ],
  exports:
  [
    CurrentTimeComponent,    
    ButtonBackComponent,
    ButtonTopComponent,

    MenuLeftDesktopComponent,
    MenuRightDesktopComponent,
    MenuLeftMobileComponent,
    MenuRightMobileComponent,

    MenuTriggerLeftComponent,
    MenuTriggerRightComponent,
    MenuTriggerLeftInfoComponent,
    MenuTriggerRightSearchComponent,   
    MenuTriggerRightFilterComponent,

    PanelCrudDesktopComponent,
    PanelCrudMobileComponent,

    RouterModule,                // RouterLink
    ReactiveFormsModule,         // Form Use ( ngModel, ... )
    FormsModule,                 // Form Use ( onSubmit, ... )
    NgxPaginationModule,         // NGX Pagination Module

    // Pipes :

    FormatDurationPipe,
    FormatSizePipe
  ]
})
export class SharedModule { }
