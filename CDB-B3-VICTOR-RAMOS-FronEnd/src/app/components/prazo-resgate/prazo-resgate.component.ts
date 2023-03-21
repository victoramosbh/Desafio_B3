import { Component, OnInit,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-prazo-resgate',
  templateUrl: './prazo-resgate.component.html',
  styleUrls: ['./prazo-resgate.component.css']
})
export class PrazoResgateComponent implements OnInit {

  value: number = 2;
  @Output() prazo = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
    this.prazo.emit(this.value);
  }

  modelChanged(valor:number) {
    if(valor != null){      
      this.prazo.emit(this.value);
    } 
  }

}
