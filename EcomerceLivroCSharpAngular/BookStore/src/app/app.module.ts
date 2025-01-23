import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/book-store-app/shaed/header/header.component';
import { FooterComponent } from './components/book-store-app/shaed/footer/footer.component';
import { NavComponent } from './components/book-store-app/shaed/nav/nav.component';
import { BookStoreAppComponent } from './components/book-store-app/book-store-app.component';
import { FiltersComponent } from './components/book-store-app/filters/filters.component';
import { ProductListComponent } from './components/book-store-app/product-list/product-list.component';
import { provideHttpClient } from '@angular/common/http';
import { ProductItensComponent } from './components/book-store-app/product-list/product-itens/product-itens.component';
import { BookService } from './services/product-list-cmponent-service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    BookStoreAppComponent,
    FiltersComponent,
    ProductListComponent,
    ProductItensComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [provideHttpClient(), BookService],
  bootstrap: [AppComponent]
})
export class AppModule { }
