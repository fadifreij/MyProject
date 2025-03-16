import { CommonModule} from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { CarouselComponent } from '../../common/carousel/carousel.component';
import { CarousalComponent } from '../../common/carousal/carousal.component';

@Component({
    selector: 'app-home',
    imports: [
        CommonModule,
        CarousalComponent,
    ],
    templateUrl: './Home.component.html',
    styleUrl: './Home.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent {
  currentIndex = 0;
  displayedImages = [
    {'img': 'img/categories/cat-1.jpg','lbl':' img 1'},
    {'img': 'img/categories/cat-2.jpg', 'lbl':' img 2' },
    {'img': 'img/categories/cat-3.jpg', 'lbl':' img 3' },
    {'img': 'img/categories/cat-4.jpg', 'lbl': ' img4' },
    {'img': 'img/categories/cat-5.jpg', 'lbl': ' img 5' },
  ]
 

 

  
 }
