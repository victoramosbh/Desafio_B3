import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Investimento } from '../models/investimento';
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

  calcularCdb(valor: number,prazo: number): Observable<Investimento> {
    return this.httpClient.get<Investimento>(this.url + '/?valor=' + valor + "&meses=" + prazo)
      .pipe(
        catchError(this.handleError)
      )
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
    console.log(errorMessage);
    return throwError(errorMessage);
  };
  
}
