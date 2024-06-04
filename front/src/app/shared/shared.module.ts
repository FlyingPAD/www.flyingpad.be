import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ButtonBackComponent } from './components/button-back/button-back.component';
import { CurrentTimeComponent } from './components/current-time/current-time.component';
import { RouterModule } from '@angular/router';
import { NgxPaginationModule } from 'ngx-pagination';
import { CommonModule } from '@angular/common';
import { FormatDurationPipe } from './pipes/format-duration.pipe';
import { FormatSizePipe } from './pipes/format-size.pipe';
import { ButtonTopComponent } from './components/button-top/button-top.component';
import { AnimRandomDirective } from './directives/anim-random.directive';
import { AnimGrowDirective } from './directives/anim-grow.directive';
import { AnimSpinDirective } from './directives/anim-spin.directive';

@NgModule({
  declarations: 
  [
    // Components :

    CurrentTimeComponent,
    ButtonBackComponent,
    ButtonTopComponent,

    // Pipes :

    FormatDurationPipe,
    FormatSizePipe,

    // Directives :

    AnimRandomDirective,
    AnimGrowDirective,
    AnimSpinDirective,
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
    AnimSpinDirective,
  ]
})
export class SharedModule { }
