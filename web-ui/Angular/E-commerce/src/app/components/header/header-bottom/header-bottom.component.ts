import { animate, state, style, transition, trigger } from '@angular/animations';
import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { CategoryService } from '../../../services/categoryService';
import { DepartmentService } from '../../../services/departmentService';
import { ClickOutsideDirective } from './click-outside.directive';

enum Comp {
    Category = 'categories',
    Department = 'departments',
}
@Component({
    selector: 'app-header-bottom',
    imports: [
        CommonModule,
        ClickOutsideDirective
    ],
    templateUrl: './header-bottom.component.html',
    styleUrl: './header-bottom.component.css',
    animations: [
        trigger('toggleList', [
            state('open', style({
                height: '*',
                opacity: 1,
            })),
            state('closed', style({
                height: '0px',
                opacity: 0,
                overflow: 'hidden',
            })),
            transition('open <=> closed', [
                animate('0.3s ease-in-out')
            ]),
        ])
    ],
    providers: [CategoryService, DepartmentService],
    standalone: true,
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HeaderBottomComponent {
    isOpen: Record<Comp, boolean> = {
        [Comp.Category]: false,
        [Comp.Department]: true,
    };

    private readonly categoryService = inject(CategoryService);
    private readonly departmentService = inject(DepartmentService);
    public categories: any;

    constructor() {
        this.categoryService.getCategories().subscribe(categories => { this.categories = categories; });
    }

    toggleList(Comp: string) {
        const key = Comp as Comp;
        this.isOpen[key] = !this.isOpen[key];

    }
    closeList(name: string) {
        const key = name as Comp;
        this.isOpen[key] = false;
    }

}
