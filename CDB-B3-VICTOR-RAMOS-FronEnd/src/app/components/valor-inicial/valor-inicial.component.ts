import { Component, OnInit,Output,EventEmitter  } from '@angular/core';

@Component({
  selector: 'app-valor-inicial',
  templateUrl: './valor-inicial.component.html',
  styleUrls: ['./valor-inicial.component.css']
})
export class ValorInicialComponent implements OnInit {

  value: number = 0;
  @Output() valorInicial = new EventEmitter();

  constructor() { 

  }

  modelChanged(valor:number) {
    if(valor != null){
      this.valorInicial.emit(this.value);
    }    
}

  ngOnInit(): void {
    this.valorInicial.emit(this.value);
  }

}
