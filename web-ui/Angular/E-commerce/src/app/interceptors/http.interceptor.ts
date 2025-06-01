// src/app/interceptors/http-error.interceptor.ts
import {
    HttpErrorResponse,
    HttpInterceptorFn    
} from '@angular/common/http';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';


export const httpInterceptor:HttpInterceptorFn = (req, next) =>{
    return next(req).pipe(
        catchError((error: HttpErrorResponse) => {
            // Centralized error handling logic
            if (error.status === 401) {
                console.warn('Unauthorized - maybe redirect to login');
            } else if (error.status === 500) {
                console.error('Server error occurred');
            } else {
                console.error('Unhandled HTTP error', error );
            }

            return throwError(() => error);
        })
    );
}

