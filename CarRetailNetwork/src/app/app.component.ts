import { Component } from '@angular/core';

@Component({
  selector:       'app-root',
  templateUrl:    './app.component.html',
  styleUrls:      ['./app.component.less']
})

export class AppComponent {
  title = 'CarRetailNetwork';
  now: number;

  constructor() {
    setInterval(() => { this.now = Date.now(); }, 500);
  }
}
