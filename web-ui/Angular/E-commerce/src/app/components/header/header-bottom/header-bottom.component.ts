import { animate, state, style, transition, trigger } from '@angular/animations';
import { CommonModule } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import {  provideAnimations } from '@angular/platform-browser/animations';

@Component({
    selector: 'app-header-bottom',
    imports: [
        CommonModule,
    ],
    templateUrl: './header-bottom.component.html',
    styleUrl: './header-bottom.component.css',
    animations: [
        trigger('toggleList', [
            state('open', style({
                height: '*',
                opacity: 1,
            })),
            state('closed', style({
                height: '0px',
                opacity: 0,
                overflow: 'hidden',
            })),
            transition('open <=> closed', [
                animate('0.3s ease-in-out')
            ]),
        ])
    ],
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class HeaderBottomComponent {
  isOpen = false;
  toggleList() {
    this.isOpen = !this.isOpen;
  }
 }
