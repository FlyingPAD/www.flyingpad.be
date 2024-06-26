import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { TokenInterceptor } from './interceptor/token.interceptor';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CookieService } from 'ngx-cookie-service';
import { ToastrModule } from 'ngx-toastr';
import { ErrorInterceptor } from './interceptor/error.interceptor';
import { FlowComponent } from './pages/flow/flow.component';
import { MoodDetailsComponent } from './components/mood-details/mood-details.component';
import { MoodGalleryComponent } from './components/mood-gallery/mood-gallery.component';
import { SharedModule } from './shared/shared.module';
import { AboutComponent } from './pages/about/about.component';
import { DemoComponent } from './pages/demo/demo.component';
import { HomeComponent } from './pages/home/home.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
import { UserLoginErrorComponent } from './pages/user-login-error/user-login-error.component';
import { UserRegisterComponent } from './pages/user-register/user-register.component';
import { VideoTestComponent } from './pages/video-test/video-test.component';
import { LayoutEmptyComponent } from './layouts/layout-empty/layout-empty.component';
import { LayoutCustomComponent } from './layouts/layout-custom/layout-custom.component';
import { ModelGalleryComponent } from './features/models/model-gallery/model-gallery.component';
import { EditionComponent } from './features/models/edition/edition.component';

@NgModule({
  declarations: 
  [
    AppComponent,
    FlowComponent,
    MoodDetailsComponent,
    MoodGalleryComponent,
    HomeComponent,
    AboutComponent,
    NotFoundComponent,
    LayoutEmptyComponent,
    LayoutCustomComponent,
    VideoTestComponent,
    DemoComponent,
    UserRegisterComponent,
    UserLoginErrorComponent,
    ModelGalleryComponent,
    EditionComponent
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
    SharedModule
  ],
  exports:
  [
    MoodDetailsComponent,
    MoodGalleryComponent,
  ],
  providers: 
  [
    // Additional providers :
    // Provider for the cookies service.
    [CookieService],              
              
    // Provider for HTTP Interceptor to handle tokens :
    { provide: HTTP_INTERCEPTORS, useClass: TokenInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }