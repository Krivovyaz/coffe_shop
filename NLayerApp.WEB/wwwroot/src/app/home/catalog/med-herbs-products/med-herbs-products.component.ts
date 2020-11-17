import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog.service";
import {Product} from "../../../product";

@Component({
  selector: 'med-herbs-products',
  templateUrl: './med-herbs-products.component.html',
  styleUrls: ['./med-herbs-products.component.scss',
              '../catalog.component.scss'
  ]
})
export class MedHerbsProductsComponent implements OnInit {

  constructor(private catalogService:CatalogService) { }

  ngOnInit(): void {
    this.getHerbs();
  }

  herbsList:Product[];
  
  getHerbs():void {
    this.catalogService.getCategory('medherbs').subscribe(products => this.herbsList = products);
  }

  addToBasket(item:Product): void {
    this.catalogService.addToBasket(item);
  }
  
}
