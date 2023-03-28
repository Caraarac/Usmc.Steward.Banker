import { Component, OnInit } from '@angular/core';
import { BankerService } from '../services/banker.service';

@Component({
  selector: 'lib-banker',
  template: ` <p>banker works!</p> `,
  styles: [],
})
export class BankerComponent implements OnInit {
  constructor(private service: BankerService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
