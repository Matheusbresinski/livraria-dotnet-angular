import { Component, Input, OnInit } from '@angular/core';
import { livro } from '../model/livro';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.css']
})
export class ProductItemComponent implements OnInit {

  url : string = "";

  @Input()
  livro!: livro;

    constructor() {}

    ngOnInit(): void {

    }
}
