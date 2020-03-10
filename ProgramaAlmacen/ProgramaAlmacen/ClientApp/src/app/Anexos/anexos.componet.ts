import { Component, OnInit } from '@angular/core';
import { IAnexos } from './Anexos';
import { AnexosService } from './anexos.service';
import { error } from 'protractor';

@Component({

  selector: 'app-anexos',
  templateUrl: "./Anexos.component.html"

})
export class AnexosComponent implements OnInit {

  anexo: IAnexos[];

  constructor(private AnexosService: AnexosService) { }

  ngOnInit() {
    this.AnexosService.getAnexos()
      .subscribe(anexo => this.anexo = anexo)
  }
}
