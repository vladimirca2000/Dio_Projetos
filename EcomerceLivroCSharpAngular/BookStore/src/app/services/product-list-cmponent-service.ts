import { Injectable, inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Book } from '../model/book';


@Injectable({
  providedIn: 'root'
})


export class BookService {
    private readonly _http = inject(HttpClient);
    private url = 'https://localhost:7089/api/Livraria';
    constructor(private http: HttpClient) { }

    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    };

    getBooks() {
        return this.http.get(this.url);
    }
}