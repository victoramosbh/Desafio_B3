<h1 align="center">
  [B]³ DESAFIO DO CÁLCULO DO CDB
</h1>

## OBJETIVO
<p>
Avaliar a capacidade de análise do desenvolvedor e a habilidade para implementação de soluções fundamentadas pelos princípios do SOLID, Testes unitários e performance.
</p>
<p>
## Frontend
Projeto criado com Angular.
Solicitamos a criação de uma tela web onde possamos informar um valor monetário positivo, e um prazo em meses maior que 1(um) para resgate da aplicação. Após solicitar o cálculo do investimento, a tela deve apresentar o resultado bruto e o resultado líquido do investimento.
</p>
<p>

## Backend
Projeto criado com .NET Framework 4.8
Solicitamos a criação de uma Web API que receba os dados informados para o cálculo do CDB.
</p>

## Clonar repositório
```https://github.com/victoramosbh/Desafio_B3.git```

## Execução
#### Backend
1. Ir para o diretório da api CDB-B3-VICTOR-RAMOS-Api<br>
 ```cd CDB-B3-VICTOR-RAMOS-Api\```
2. Executar a api com comando dotnet<br>
```dotnet run``` <br><br>
Chamada para teste do endpoint **http://localhost:63160/api/investimentos/calcularcdb/?valor=10000&meses=3**.


#### Frontend
1. Com base na pasta raiz do projeto, alterar para o diretório do projeto do frontend<br>
 ```cd .\frontend\desafio```
2. Antes de executar o projeto, deve ser feito o download das dependências utilizando o npm<br>
```npm i```
3. Iniciar utilizando o comando abaixo<br>
```ng serve -o```<br><br>
Após esse comando a janela do navegador deve abrir e apresentar a tela do projeto. Caso não abra, basta abrir um browser e navegar para a página **http://localhost:4200/**

## Execução através do docker
Caso possua o docker instalado, a forma mais fácil de ter o ambiente pronto para execução é através do comando ```docker-compose up``` que irá carregar as imagens dos dois projetos. Após as imagens terem sido carregadas, o endpoint de acesso à API será o **http://localhost/api/cdb** e a página web poderá ser acessada através do endereço **http://localhost/**<br>

## Testes do backend
Foram criado 3 projetos de testes que se encontram na pasta [backend](./backend/). Para executar os testes basta digitar o comando ```dotnet test``` dentro de cada pasta.
<hr>
