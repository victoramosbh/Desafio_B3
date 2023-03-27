import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { take,catchError  } from 'rxjs/operators';
import { Investimento } from '../models/investimento';
import { InvestimentoRequest } from '../models/investimento-request';
import { environment } from './../../environments/environment'

@Injectable({
  providedIn: 'root'
})
export class InvestimentoService {

  url = environment.apiUrl;
  
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  constructor(private httpClient: HttpClient) { }


   calcularCdb(data: InvestimentoRequest): Observable<Investimento> {    
    return this.httpClient.post<Investimento>(this.url, data, this.httpOptions)
    .pipe(take(1));
  } 

  handleError(error: HttpErrorResponse) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Erro ocorreu no lado do client
      errorMessage = error.error.message;
    } else {
      // Erro ocorreu no lado do servidor
      errorMessage = "Código do erro: " + error.status  + "; Menssagem: " + error.message;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  };
  
}
