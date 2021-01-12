import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Produto } from '../Models/Produto';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ProdutoService } from '../services/produto.service';

@Component({
  selector: 'app-produtos',
  templateUrl: 'produtos.component.html'
})
export class ProdutosComponent {

  public tituloProduto = 'Produtos';
  public produtoSelected: Produto = new Produto();
  public modalRef: BsModalRef = new BsModalRef;
  public metodo = 'salvar';

  produtoForm = new FormGroup({
    id: new FormControl(''),
    descricao: new FormControl(''),
    modoPreparoId: new FormControl(''),
  });

  public produtos: Produto[] = []

  constructor(private fb: FormBuilder,
    // private modalService: BsModalService,
    private produtoServico: ProdutoService) {
    this.createForm();
  }

  // openModal(template: TemplateRef<any>) {
  //   this.modalRef = this.modalService.show(template);
  // }

  createForm() {
    this.produtoForm = this.fb.group({
      id: [''],
      descricao: ['', Validators.required],
      modoPreparoId: ['', Validators.required],
    })
  }

  ngOnInit(): void {
    this.carregarProdutos();
  }

  carregarProdutos() {
    this.produtoServico.obterTodos().subscribe(
      (resultado: Produto[]) => {
        this.produtos = resultado;
        console.log(this.produtos);
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  produtoSelect(produto: Produto) {
    this.produtoSelected = produto;
    this.produtoForm.patchValue(produto);
  }

  novoProduto() {
    this.produtoSelected = new Produto();
    this.produtoSelected.id = -1;
    this.produtoForm.patchValue(this.produtoSelected);
  }

  salvarProduto(produto: Produto) {
    if (this.produtoSelected.id === -1) {
      produto.id = 0;
      this.produtoServico.salvar(produto).subscribe(
        (resultado: any) => {
          console.log(resultado);
          this.produtoSelected = resultado;
          this.carregarProdutos();
        },
        (erro: any) => {
          console.log(erro);
        }
      );
    } else {
      this.produtoServico.editar(produto).subscribe(
        (resultado: any) => {
          console.log(resultado);
          this.produtoSelected = resultado;
          this.carregarProdutos();
        },
        (erro: any) => {
          console.log(erro);
        }
      );
    }
  }

  excluirProduto(produto: Produto) {
    this.produtoServico.deletar(produto.id).subscribe(
      (retorno: any) => {
        console.log(retorno);
        this.carregarProdutos();
      },
      (erro: any) => {
        console.log(erro);
      }
    );
  }

  onSubmit() {
    this.salvarProduto(this.produtoForm.value);
  }

  voltar() {
    this.produtoSelected = new Produto();
  }
}
