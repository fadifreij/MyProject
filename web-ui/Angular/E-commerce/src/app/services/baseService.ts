import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
export abstract class BaseService<T> {
    private Url: string;

    constructor(
        protected http: HttpClient,
        private endpoint: string
    ) {

        this.Url = `${environment.apiUrl}/${this.endpoint}`;
    }

    getAll(params?: HttpParams): Observable<T[]> {
        return this.http.get<T[]>(this.Url, { params });
    }

    getById(id: number | string): Observable<T> {
        return this.http.get<T>(`${this.Url}/${id}`);
    }

    create(item: T): Observable<T> {
        return this.http.post<T>(this.Url, item);
    }

    update(id: number | string, item: T): Observable<T> {
        return this.http.put<T>(`${this.Url}/${id}`, item);
    }

    delete(id: number | string): Observable<void> {
        return this.http.delete<void>(`${this.Url}/${id}`);
    }

    // Generic custom GET with any params
    getWithParams(endpoint: string, params?: HttpParams): Observable<any> {
        return this.http.get(`${this.Url}/${endpoint}`, { params });
    }

    // Custom POST/PUT/DELETE can be added similarly
}
