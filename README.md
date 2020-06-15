# Controle De Salas - BackEnd

Este projeto foi utilizado:

- ASP Core 3.1
- Entity Framework Core
- SQLServer 
- Visual Studio Community 2019
- Visual Studio Code

## Banco de Dados

Você deverá criar um banco de dados e duas tabelas para que sejam criados os registros da aplicação:

Utilizaremos o [SQL Server 2019 Express](https://go.microsoft.com/fwlink/?linkid=866658) que será nosso provider e para a criação do bando de dados e das tabelas utilizaremos o [Microsoft SQL Server Management Studio](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15).

Com as duas ferramentas acima instaladas vamos aos comandos para criação do banco de dados, tabelas e insersão de dados nessas tabelas. 

###Criação do banco de dados
CREATE DATABASE ControleDeSalas


## Servidor de desenvolvimento

Este projeto é composto de duas partes, sendo esta o BackEnd da aplicação. 
O FrontEnd você encontra neste link: (https://github.com/consule/ControleDeSalasFront)

## Executando o projeto

1. Clone o projeto com o comando (https://github.com/consule/ControleDeSalasBackEnd.git) para uma pasta de sua preferencia. 
2. Execute o comando `cd ControleDeSalasFront` para entrar na pasta que acabou de ser clonada
3. Para a instalação dos modulos execute: `npm install` ou apenas `npm i` (Aguarde até que os modulos existenetes sejam instalados automáticamente);
4. Execute `ng serve` para um servidor dev. 
5. Navegue até `http://localhost:4200/`. 

O aplicativo será recarregado automaticamente se você alterar qualquer um dos arquivos de origem.

## Atenção com as Services

Você pode encontrar as services no caminho `ControleDeSalasFront\src\app\services`. Elas são o ponto de entrada  que alimentam a aplicação e exibem os dados. 

Lembre-se sempre de conferir a porta de entrada existente (essa porta é gerada pelo FrontEnd(, e para facilitar existe uma variável em cada um desses arquivos com o nome `const apiUrl`.
