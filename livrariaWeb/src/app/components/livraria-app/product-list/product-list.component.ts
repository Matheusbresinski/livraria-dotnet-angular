import { Component, OnInit } from '@angular/core';
import { livroService } from './product-list.component.services';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit{

    livros: any;
    livroService : livroService;

    constructor(livroService: livroService){

      this.livroService = livroService;
    }

    ngOnInit(): void {

      this.livros = this.livroService.getLivro().subscribe((data =>{
        this.livros = data;
        console.log(this.livros);
      }))
    }

}
