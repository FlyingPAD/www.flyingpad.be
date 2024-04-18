import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ButtonBackComponent } from './components/button-back/button-back.component';
import { CurrentTimeComponent } from './components/current-time/current-time.component';
import { MenuRightDesktopComponent } from './components/menu-right-desktop/menu-right-desktop.component';
import { RouterModule } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';
import { CommonModule } from '@angular/common';
import { FormatDurationPipe } from './pipes/format-duration.pipe';
import { FormatSizePipe } from './pipes/format-size.pipe';
import { PanelCrudDesktopComponent } from './components/panel-crud-desktop/panel-crud-desktop.component';
import { PanelCrudMobileComponent } from './components/panel-crud-mobile/panel-crud-mobile.component';
import { ButtonTopComponent } from './components/button-top/button-top.component';
import { AnimRandomDirective } from './directives/anim-random.directive';
import { AnimGrowDirective } from './directives/anim-grow.directive';

@NgModule({
  declarations: 
  [
    // Components :

    CurrentTimeComponent,
    ButtonBackComponent,
    ButtonTopComponent,

    MenuRightDesktopComponent,

    PanelCrudDesktopComponent,
    PanelCrudMobileComponent,

    // Pipes :

    FormatDurationPipe,
    FormatSizePipe,

    // Directives :

    AnimRandomDirective,
      AnimGrowDirective,
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

    MenuRightDesktopComponent,

    PanelCrudDesktopComponent,
    PanelCrudMobileComponent,

    RouterModule,                // RouterLink
    ReactiveFormsModule,         // Form Use ( ngModel, ... )
    FormsModule,                 // Form Use ( onSubmit, ... )
    NgxPaginationModule,         // NGX Pagination Module

    // Pipes :

    FormatDurationPipe,
    FormatSizePipe,

    // Directives :

    AnimRandomDirective,
      AnimGrowDirective,
  ]
})
export class SharedModule { }
