import { Component, OnInit } from '@angular/core';
import { Investimento } from './models/investimento';
import { InvestimentoRequest } from './models/investimento-request';
import { InvestimentoService } from './services/investimento.service';


@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})
export class AppComponent implements OnInit {

  valorInicial: number = 0;
  prazo: number = 0;
  investimento: Investimento = { valorBruto: 0, valorLiquido: 0,menssagem: ""};;

  constructor(private investimentoService: InvestimentoService) {  }

  ngOnInit(): void {  }

  receberValorInicial(valor: number) {    
    this.valorInicial = valor;
  }

  receberPrazo(prazo: number) {
    this.prazo = prazo;
  }

  calcularCdb() {

    const dadosRequisicao = {
      valorInicial: this.valorInicial,
      prazo: this.prazo
    } as InvestimentoRequest;

    this.investimentoService.calcularCdb(dadosRequisicao).subscribe({
      next: (response: Investimento) => {        
        this.investimento = { ...response };
        if (this.investimento.menssagem != null && this.investimento.menssagem != "") {
          confirm(this.investimento.menssagem)
        } 
      },
      error: (error: Error) => {        
        console.error(JSON.stringify(error));
      },
    }).add();    
  }

  click() {
    this.calcularCdb();
  }
}
