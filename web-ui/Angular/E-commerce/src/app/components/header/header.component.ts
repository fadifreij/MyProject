import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { HeaderTopComponent } from "./header-top/header-top.component";
import { HeaderMiddleComponent } from './header-middle/header-middle.component';
import { HeaderBottomComponent } from './header-bottom/header-bottom.component';

@Component({
    selector: 'app-header',
    imports: [
        CommonModule,
        HeaderTopComponent,
        HeaderMiddleComponent,
        HeaderBottomComponent
    ],
    templateUrl: './header.component.html',
    styleUrl: './header.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HeaderComponent { }
