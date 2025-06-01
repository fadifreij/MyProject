import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideAnimations } from '@angular/platform-browser/animations';
import { provideRouter } from '@angular/router';
import { httpInterceptor } from './interceptors/http.interceptor';
import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { provideHttpClient, withFetch, withInterceptors } from '@angular/common/http';
export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true }), 
             provideRouter(routes), 
             provideClientHydration(withEventReplay()),
             provideAnimations(),
             provideHttpClient(
                               withFetch(),
                               withInterceptors([httpInterceptor])
                            )

            ]
};
