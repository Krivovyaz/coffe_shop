import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog.service";
import {Product} from "../../../product";

@Component({
  selector: 'coffe-products',
  templateUrl: './coffe-products.component.html',
  styleUrls: ['./coffe-products.component.scss',
              '../catalog.component.scss'
  ]
})
export class CoffeProductsComponent implements OnInit {

  isLoading = false;

  constructor(private catalogService: CatalogService) { }

  ngOnInit(): void {
    this.getCoffe();
  }
  
  coffeList:Product[];
  
  getCoffe():void {
    this.isLoading = true;
    this.catalogService.getCategory('coffe').subscribe(products => {
      this.isLoading = false;
      this.coffeList = products;
    });
    
  }

  addToBasket(item:Product): void {
    this.catalogService.addToBasket(item);
  }
  
}
