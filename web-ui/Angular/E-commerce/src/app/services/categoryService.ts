import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of, tap } from 'rxjs';
import { BaseService } from './baseService';
@Injectable({ providedIn: 'root' })
export class CategoryService extends BaseService<string> {
    private readonly CACHE_KEY = 'category_menu';

    constructor(http: HttpClient) {
        super(http, 'api/Categories');
    }

    getCategories(): Observable<string[]> {
        const cachedCategory = localStorage.getItem(this.CACHE_KEY);
        if (cachedCategory) {
            return of(JSON.parse(cachedCategory));
        } else {
            return this.getAll().pipe(
                tap(data => localStorage.setItem(this.CACHE_KEY, JSON.stringify(data)))
            );
        }
    }
}
