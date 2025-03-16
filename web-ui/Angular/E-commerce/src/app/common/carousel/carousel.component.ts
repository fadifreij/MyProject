import { CommonModule, isPlatformBrowser } from '@angular/common';
import { ChangeDetectorRef, Component, Inject, Input, OnInit, PLATFORM_ID, ViewEncapsulation } from '@angular/core';

@Component({
    selector: 'app-carousel',
    imports: [CommonModule],
    templateUrl: './carousel.component.html',
    styleUrls: ['./carousel.component.scss']
})
export class CarouselComponent implements OnInit {
  @Input() images: string[] = [];
  displayedImages: string[] = [];
  currentIndex = 0;
  autoplayInterval: any;
  @Input() displayCount: number = 1;
  @Input() autoSlide: boolean = false;
  @Input() slideInterval: number = 3000
  constructor(@Inject(PLATFORM_ID) private platformId: Object, private cdr: ChangeDetectorRef) {

  }

  ngOnInit() {
    this.displayedImages = this.images.slice(0, this.displayCount);
    if (isPlatformBrowser(this.platformId)) {
        this.startAutoplay();
    }

  }

  startAutoplay() {
    this.autoplayInterval = setInterval(() => {
     
      this.nextImage();
    }, this.slideInterval); // Change image every 3 seconds
  }

  stopAutoplay() {
    clearInterval(this.autoplayInterval);
  }


  nextImage() {
   
    const length = this.images.length;
    // Move the first image to the end of the list
    this.images.push(this.images.shift()!);
    // Update displayed images
    this.displayedImages = this.images.slice(0, this.displayCount);
    this.cdr.detectChanges();
  }

  prevImage() {
    const length = this.images.length;
    // Move the last image to the front of the list
    this.images.unshift(this.images.pop()!);
    // Update displayed images
    this.displayedImages = this.images.slice(0, this.displayCount);
  }

  ngOnDestroy() {
    this.stopAutoplay(); // Clear the interval on component destroy
  }
}
