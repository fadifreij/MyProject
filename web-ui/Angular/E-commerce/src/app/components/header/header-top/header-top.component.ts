import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
    selector: 'header-top',
    imports: [
        CommonModule,
    ],
    templateUrl: './header-top.component.html',
    styleUrl: './header-top.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HeaderTopComponent { }
