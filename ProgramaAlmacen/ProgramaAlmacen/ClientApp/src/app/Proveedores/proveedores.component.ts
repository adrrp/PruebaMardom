import { Component, OnInit } from '@angular/core';
import { IProveedores } from './Proveedores';
import { ProveedoresService } from './proveedores.service';
import { error } from 'protractor';

@Component({

  selector: 'app-anexos',
  templateUrl: "./Anexos.component.html"

})
export class Proveedores implements OnInit {

  proveedores: IProveedores[];

  constructor(private ProveedoresService: ProveedoresService) { }

  ngOnInit() {
    this.ProveedoresService.getProveedores()
      .subscribe(proveedores => this.proveedores = proveedores)
  }
}
