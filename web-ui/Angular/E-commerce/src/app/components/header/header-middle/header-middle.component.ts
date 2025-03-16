import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { RouterLink, RouterModule } from '@angular/router';

@Component({
    selector: 'header-middle',
    imports: [
        CommonModule,
        RouterModule,
    ],
    templateUrl: './header-middle.component.html',
    styleUrl: './header-middle.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HeaderMiddleComponent { }
