import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { BaseService } from "./baseService";

@Injectable({ providedIn: 'root' })
export class DepartmentService extends BaseService<Department> {
    private readonly CACHE_KEY = 'department_menu';
    private readonly baseUrl = 'api/Departments';
    constructor(http: HttpClient) {
        super(http, 'api/Departments');
    }

    getDepartments(): Observable<Department[]> {
        return this.getCachedData<Department[]>(this.CACHE_KEY, () => this.getAll());
    }

    getDepartmentsByCategoryId(categoryId: number): Observable<Department[]> {
        return this.getCachedData<Department[]>(`${this.CACHE_KEY}_category_${categoryId}`, () =>
            this.http.get<Department[]>(`${this.baseUrl}/ByCategory/${categoryId}/Get`));
    }

}
export interface Department {
    id: number;
    categoryId: number;
    categoryName: string;
}