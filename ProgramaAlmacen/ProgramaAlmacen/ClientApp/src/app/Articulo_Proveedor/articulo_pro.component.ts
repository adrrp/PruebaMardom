import { Component, OnInit } from '@angular/core';
import { IArticulo_Pro } from './Articulo_Proveedor';
import { ArticuloProService } from './articulo_pro.service';
import { error } from 'protractor';

@Component({

  selector: 'app-articulo',
  templateUrl: "./articulo.component.html"

})
export class AnexosComponent implements OnInit {

  articulopro: IArticulo_Pro[];

  constructor(private ArticuloProService: ArticuloProService) { }

  ngOnInit() {
    this.ArticuloProService.getArticulo_pro()
      .subscribe(articulopro => this.articulopro = articulopro)
  }
}
