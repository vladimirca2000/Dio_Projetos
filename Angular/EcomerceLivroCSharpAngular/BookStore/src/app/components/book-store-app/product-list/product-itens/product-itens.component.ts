import { Component, OnInit, Input } from '@angular/core';
import { Book } from '../../../../model/book';

@Component({
  selector: 'app-product-itens',
  standalone: false,
  
  templateUrl: './product-itens.component.html',
  styleUrl: './product-itens.component.css'
})
export class ProductItensComponent {
  @Input() livro!: Book;

  constructor() { }

  ngOnInit(): void {
  }


}
