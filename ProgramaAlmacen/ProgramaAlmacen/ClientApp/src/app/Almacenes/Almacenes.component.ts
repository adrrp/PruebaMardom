import { Component, OnInit } from '@angular/core';
import { IAlmacenes } from './Almacenes';
import { AlmacenService } from './almacen.service';
import { error } from 'protractor';

@Component({

  selector: 'app-almacen',
  templateUrl: "./Almacenes.component.html"
  
})
export class AlmacenesComponent implements OnInit {

   almacenes: IAlmacenes[];

  constructor(private almacenesService: AlmacenService) { }

  ngOnInit() {
    this.almacenesService.getAlmacenes()
      .subscribe(almacenes => this.almacenes = almacenes)
  }
}
