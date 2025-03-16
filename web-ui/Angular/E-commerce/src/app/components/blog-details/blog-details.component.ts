import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
    selector: 'app-blog-details',
    imports: [CommonModule],
    templateUrl: './blog-details.component.html',
    styleUrl: './blog-details.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class BlogDetailsComponent { }
