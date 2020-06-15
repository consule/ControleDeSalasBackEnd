# Controle De Salas - BackEnd

Este projeto foi utilizado:

DotNet Core 3.1
Entity Framework Core


[Angular CLI](https://github.com/angular/angular-cli) version 8.3.17.

## Servidor de desenvolvimento

Este projeto é composto de duas partes, sendo esta o BackEnd da aplicação. 
O FrontEnd você encontra neste link: (https://github.com/consule/ControleDeSalasFront)

## Executando o projeto

1. Clone o projeto com o comando (https://github.com/consule/ControleDeSalasFront.git) para uma pasta de sua preferencia. 
2. Execute o comando `cd ControleDeSalasFront` para entrar na pasta que acabou de ser clonada
3. Para a instalação dos modulos execute: `npm install` ou apenas `npm i` (Aguarde até que os modulos existenetes sejam instalados automáticamente);
4. Execute `ng serve` para um servidor dev. 
5. Navegue até `http://localhost:4200/`. 

O aplicativo será recarregado automaticamente se você alterar qualquer um dos arquivos de origem.

## Atenção com as Services

Você pode encontrar as services no caminho `ControleDeSalasFront\src\app\services`. Elas são o ponto de entrada  que alimentam a aplicação e exibem os dados. 

Lembre-se sempre de conferir a porta de entrada existente (essa porta é gerada pelo FrontEnd(, e para facilitar existe uma variável em cada um desses arquivos com o nome `const apiUrl`.
