import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IAlmacenes } from '../Almacenes';

@Component({

  selector: 'app-almacen',
  templateUrl: "./almacenes-form.component.html"

})
export class AlmacenesFormComponent implements OnInit {

  constructor(private fb: FormBuilder) { }
  formGroup: FormGroup;

  ngOnInit() {
    this.formGroup = this.fb.group({
      nombre: '',
      descripcion: '',
      telefono: '',
      correoElectronico: '',
      ubicacion: '',
      capacidadArticulos: '',
      proveedores: ''
    });
     
  }

  save() {
    let almacen: IAlmacenes = Object.assign({}, this.formGroup.value);
    console.table(almacen);
  }
}
