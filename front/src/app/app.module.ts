import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { TokenInterceptor } from './core/interceptor/token.interceptor';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { LayoutCoreComponent } from './core/layouts/layout-core/layout-core.component';
import { CoreModule } from './core/core.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CookieService } from 'ngx-cookie-service';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './core/interceptor/error.interceptor';

//  - WELCOME to the Flying PAD Front DEV !

console.log(' ---------------------------------- ')
console.log('  Flying PAD | Version 1.0')
console.log(' ---------------------------------- ')

@NgModule({
  declarations: 
  [
    AppComponent,
    LayoutCoreComponent,
  ],
  imports: 
  [
    // --- CORE :

    BrowserModule,
    AppRoutingModule,

    // --- NATIVE :

    HttpClientModule,                       // Manual Import

    BrowserAnimationsModule,                // Enables Animations ( Required for Toastr )

    // Toastr Configuration :
    
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',  // Position of the toastr notifications on the screen
      timeOut: 3000,                        // Duration in milliseconds for which toastr will be displayed (3 seconds)
      progressBar: true,                    // Whether to show a progress bar indicating time remaining
      closeButton: true,                    // Whether to display a close button on the toastr
      preventDuplicates: true,              // Whether to prevent duplicate toastr from appearing
      tapToDismiss: true,                   // Whether to allow dismissing toastr by clicking on it
      newestOnTop: true,                    // Whether new toastr should appear on top of the older ones
      easeTime: 500,                        // Duration of slide-in/out animation in milliseconds
      enableHtml: true                      // Whether HTML content is allowed in toastr messages
    }),
    CoreModule
  ],
  providers: 
  [
    // Additional providers :

    [CookieService],                        // Provider for the cookies service

    // Provider for HTTP Interceptor to handle tokens :

    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }