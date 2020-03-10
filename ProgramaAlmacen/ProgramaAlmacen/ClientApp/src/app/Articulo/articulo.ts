import { DecimalPipe } from "@angular/common";

export interface IArticulos {

  id: number;
  codigoArticulo: string;
  nombre: string;
  descripcion: string;
  marcaArticulo: string;
  precioCompra: number;
  precioVenta: number;
  ganancias: number;
  stock: number;
  estatus: boolean;
  fechaIngreso: Date;
  fechaVenta: Date;

}
