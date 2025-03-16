import { CommonModule, isPlatformBrowser } from '@angular/common';
import { ApplicationRef, ChangeDetectionStrategy, ChangeDetectorRef, Component, Inject, Input, input, NgZone, OnInit, PLATFORM_ID, TemplateRef } from '@angular/core';
import { CarouselModule } from 'primeng/carousel';
@Component({
    selector: 'app-carousal',
    imports: [
        CommonModule,
        CarouselModule
    ],
    templateUrl: './carousal.component.html',
    styleUrl: './carousal.component.css',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class CarousalComponent implements OnInit { 
  responsiveOptions: any[] | undefined;
  products  = input.required<any>();
  showArrow = input<boolean>(false)
  numVisible = input.required<number>()
  @Input() contentTemplate!: TemplateRef<any>;

  isBrowser: boolean;
  interval = 3000;
  intervalTimeout: any;
  
  constructor(@Inject(PLATFORM_ID) private platformId: Object, 
              private appRef: ApplicationRef,
              private cdr: ChangeDetectorRef,
              private ngZone:NgZone) {
    this.isBrowser = isPlatformBrowser(this.platformId);
   
  }
  ngOnInit(): void {
    this.appRef.isStable.subscribe((isStable) => {
     // console.log('App stable:', isStable);
    });
    this.responsiveOptions = [
      {
        breakpoint: '1199px',
        numVisible: 1,
        numScroll: 1
      },
      {
        breakpoint: '991px',
        numVisible: 2,
        numScroll: 1
      },
      {
        breakpoint: '767px',
        numVisible: 1,
        numScroll: 1
      }
    ];
  }

  resetAutoScroll() {
   // Clear any existing timer
    if (this.intervalTimeout>0) {
      this.ngZone.runOutsideAngular(() => {
        clearTimeout(this.intervalTimeout)
      });
     
    
    }
   

    this.ngZone.runOutsideAngular(() => {
     this.intervalTimeout = setInterval(() => { this.interval = 3000 });
    });
    


    this.cdr.detectChanges();
  }
}
