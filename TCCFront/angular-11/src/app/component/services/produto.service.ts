import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment'
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Produto } from '../Models/Produto';


@Injectable({
  providedIn: 'root'
})
export class ProdutoService {

  urlBase = `${environment.urlApi}produto`;

  constructor(private http: HttpClient) { }

  obterTodos(): Observable<Produto[]> {
    return this.http.get<Produto[]>(this.urlBase);
  }

  salvar(produto: Produto) {
    return this.http.post(this.urlBase, produto);
  }

  deletar(id: number) {
    return this.http.delete(`${this.urlBase}produtoid=${id}`);
  }

  editar(produto: Produto) {
    return this.http.put(`${this.urlBase}produtoid=${produto.id}`, produto);
  }
}