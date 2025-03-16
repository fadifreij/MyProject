import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { CarousalComponent } from '../../common/carousal/carousal.component';

@Component({
    selector: 'app-shop',
    imports: [
        CommonModule,
        CarousalComponent
    ],
    templateUrl: './shop.component.html',
    styleUrl: './shop.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ShopComponent {
   products = [{
     'img':'img/product/discount/pd-1.jpg',
      'discount':-20,
      'category':'Vegtables',
      'label':'label 1',
      'price':30
     },
     {
       'img': 'img/product/discount/pd-2.jpg',
       'discount': -20,
       'category': 'Dried Food',
       'label': 'label 2',
       'price': 50
     },
     {
       'img': 'img/product/discount/pd-3.jpg',
       'discount': -20,
       'category': 'Vegtables',
       'label': 'label 3',
       'price': 20
     },
     {
       'img': 'img/product/discount/pd-4.jpg',
       'discount': -20,
       'category': 'Dried Food',
       'label': 'label 4',
       'price': 120
     },
     {
       'img': 'img/product/discount/pd-5.jpg',
       'discount': -20,
       'category': 'Vegtables',
       'label': 'label 5',
       'price': 60
     },
     {
       'img': 'img/product/discount/pd-6.jpg',
       'discount': -20,
       'category': 'Vegtables',
       'label': 'label 6',
       'price': 160
     }

  ]
 }
