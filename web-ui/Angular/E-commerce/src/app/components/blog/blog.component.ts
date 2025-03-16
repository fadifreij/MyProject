import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
    selector: 'app-blog',
    imports: [CommonModule],
    templateUrl: './blog.component.html',
    styleUrl: './blog.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class BlogComponent { }
