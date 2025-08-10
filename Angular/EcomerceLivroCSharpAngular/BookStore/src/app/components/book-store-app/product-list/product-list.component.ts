import { Component } from '@angular/core';
import { BookService } from '../../../services/product-list-cmponent-service';

@Component({
  selector: 'app-product-list',
  standalone: false,
  
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent {
  livros: any;
  bookService: BookService;
  constructor(bookService: BookService) {
      this.bookService = bookService;
   }

  ngOnInit(): void {
    this.livros = this.bookService.getBooks().subscribe((data) => {
      this.livros = data;
      console.log(this.livros);
    });
  }

}
