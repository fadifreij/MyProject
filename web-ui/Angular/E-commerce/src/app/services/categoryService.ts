import { HttpClient } from '@angular/common/http';
import { inject, Injectable, PLATFORM_ID } from '@angular/core';
import { Observable, of, tap } from 'rxjs';
import { BaseService } from './baseService';
import { isPlatformBrowser } from '@angular/common';
@Injectable({ providedIn: 'root' })
export class CategoryService extends BaseService<Category> {
    private readonly CACHE_KEY = 'category_menu';
   
    constructor(http: HttpClient) {
        const baseUrl = 'api/Categories';
        super(http, baseUrl);
    }

    getCategories(): Observable<Category[]> {
        return this.getCachedData<Category[]>(this.CACHE_KEY, () => this.getAll());
    }
}


export interface Category {
    id: number;
    categoryName:string;
}
