<h1 align="center">
  [B]³ DESAFIO DO CÁLCULO DO CDB
</h1>

## OBJETIVO
<p>
Avaliar a capacidade de análise do desenvolvedor e a habilidade para implementação de soluções fundamentadas pelos princípios do SOLID, Testes unitários e performance.
</p>
<p>

## Frontend
Projeto criado com Angular.<br>
Solicitamos a criação de uma tela web onde possamos informar um valor monetário positivo, e um prazo em meses maior que 1(um) para resgate da aplicação. Após solicitar o cálculo do investimento, a tela deve apresentar o resultado bruto e o resultado líquido do investimento.
</p>
<p>

## Backend
Projeto criado com .NET Framework 4.8.<br>
Solicitamos a criação de uma Web API que receba os dados informados para o cálculo do CDB.
</p>

## Clonar repositório
```https://github.com/victoramosbh/Desafio_B3.git```

## Execução

Executar os comandos tendo como base a pasta raiz do projeto CDB-B3-VICTOR-RAMOS.

#### Backend
1. Ir para o diretório da api CDB-B3-VICTOR-RAMOS-Api<br>
 ```cd CDB-B3-VICTOR-RAMOS-Api\```
2. Executar a api com comando dotnet<br>
```dotnet run``` <br>
Chamada para teste do endpoint  **http://localhost:63160/api/investimentos/calcularcdb/?valor=10000&meses=3**


#### Frontend
1. Ir para o diretório do frontend CDB-B3-VICTOR-RAMOS-FronEnd<br>
 ```cd CDB-B3-VICTOR-RAMOS-FronEnd```
2. Fazer download das dependências<br>
```npm i```
3. Iniciar o servidor <br>
```ng serve -o```<br><br>
Abrir o navegador e acessar **http://localhost:4200/**


## Testes Unitários
Para executar os testes executar o comando ```dotnet test``` dentro da pasta CDB-B3-VICTOR-RAMOS-Test.
<hr>