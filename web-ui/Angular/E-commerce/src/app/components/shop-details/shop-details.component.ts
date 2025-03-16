import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
    selector: 'app-shop-details',
    imports: [CommonModule],
    templateUrl: './shop-details.component.html',
    styleUrl: './shop-details.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ShopDetailsComponent { }
