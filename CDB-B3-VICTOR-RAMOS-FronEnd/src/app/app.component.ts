import { Component, OnInit } from '@angular/core';
import { Investimento } from './models/investimento';
import { InvestimentoService } from './services/investimento.service';


@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})
export class AppComponent implements OnInit {

  valorInicial: number = 0;
  prazo: number = 0;
  investimento: Investimento = { ValorBruto: 0, ValorLiquido: 0, Mensagem: "" };;

  constructor(private investimentoService: InvestimentoService) {  }

  ngOnInit(): void {  }

  receberValorInicial(valor: number) {    
    this.valorInicial = valor;
  }

  receberPrazo(prazo: number) {
    this.prazo = prazo;
  }

  calcularCdb() {

    this.investimentoService.calcularCdb(this.valorInicial, this.prazo).subscribe((investimento: Investimento) => {
      this.investimento = investimento;

      if (this.investimento.Mensagem != null && this.investimento.Mensagem != "") {
        confirm(this.investimento.Mensagem)
      }
    });
    
  }

  click() {
    this.calcularCdb();
  }
}
