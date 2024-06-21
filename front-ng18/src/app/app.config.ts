import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter, withComponentInputBinding, withRouterConfig, withViewTransitions } from '@angular/router';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideToastr } from 'ngx-toastr';
import { authInterceptor, routes } from './app.routes';
import { CookieService } from 'ngx-cookie-service';
import { provideHttpClient, withFetch, withInterceptors } from '@angular/common/http';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

export const appConfig: ApplicationConfig = {
  providers: [
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes, withComponentInputBinding(), withRouterConfig({onSameUrlNavigation: 'reload'}), withViewTransitions()),
    provideAnimations(),
    provideToastr({
      positionClass: 'toast-bottom-right',  // Position on the screen
      timeOut: 3000,                        // Duration in milliseconds
      progressBar: true,                    // Whether to show a progress bar indicating time remaining
      closeButton: true,                    // Whether to display a close button on the toastr
      preventDuplicates: true,              // Whether to prevent duplicate toastr from appearing
      tapToDismiss: true,                   // Whether to allow dismissing toastr by clicking on it
      newestOnTop: true,                    // Whether new toastr should appear on top of the older ones
      easeTime: 500,                        // Duration of slide-in/out animation in milliseconds
      enableHtml: true                      // Whether HTML content is allowed in toastr messages
    }),
    CookieService,
    provideHttpClient(withFetch(), withInterceptors([authInterceptor])), 
    provideAnimationsAsync()
  ],
};