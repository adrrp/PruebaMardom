import { Component, OnInit } from '@angular/core';
import { IArticulo } from './Articulo';
import { ArticuloService } from './articulo.service';
import { error } from 'protractor';

@Component({

  selector: 'app-articulo',
  templateUrl: "./Anexos.component.html"

})
export class AnexosComponent implements OnInit {

  articulo: IArticulo[];

  constructor(private ArticuloService: ArticuloService) { }

  ngOnInit() {
    this.ArticuloService.getArticulo()
      .subscribe(articulo => this.articulo = articulo)
  }
}
