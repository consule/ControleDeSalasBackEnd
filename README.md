# Controle De Salas - BackEnd

Este projeto foi utilizado:

- ASP Core 3.1
- Entity Framework Core
- SQLServer 
- Visual Studio Community 2019

## Servidor de desenvolvimento

Este projeto é composto de duas partes, sendo esta o BackEnd da aplicação. 
O FrontEnd você encontra neste link: (https://github.com/consule/ControleDeSalasFront)

## Banco de Dados

Você deverá criar um banco de dados e duas tabelas para que sejam criados os registros da aplicação:

Utilizaremos o [SQL Server 2019 Express](https://go.microsoft.com/fwlink/?linkid=866658) que será nosso provider e para a criação do bando de dados e das tabelas utilizaremos o [Microsoft SQL Server Management Studio](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15).

Com as duas ferramentas acima instaladas vamos aos comandos para criação do banco de dados, tabelas e insersão de dados nessas tabelas. 

### Criação do banco de dados

##### Criando o Banco de Dados:
`CREATE DATABASE ControleDeSalas`

##### Criando as tabelas Salas e Agendamentos:

###### Tabela Salas
```
CREATE TABLE [dbo].[Salas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Capacidade] [int] NOT NULL,
	[DataCriacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Salas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
```

###### Tabela Agendamentos

```USE [ControleDeSalas]

CREATE TABLE [dbo].[Agendamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdSala] [int] NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[DataHoraInicial] [datetime] NOT NULL,
	[DataHoraFinal] [datetime] NOT NULL,
 CONSTRAINT [PK_Agendamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Agendamentos]  WITH CHECK ADD  CONSTRAINT [FK_Agendamentos_Salas] FOREIGN KEY([IdSala])
REFERENCES [dbo].[Salas] ([Id])
GO

ALTER TABLE [dbo].[Agendamentos] CHECK CONSTRAINT [FK_Agendamentos_Salas]
GO```

###### Populando a tabela Salas:

`insert into Salas (Nome, Capacidade, DataCriacao) values ('Reunião', 45, getdate())`

`insert into Salas (Nome, Capacidade, DataCriacao) values ('Oval', 10, getdate())`

`insert into Salas (Nome, Capacidade, DataCriacao) values ('Descanso', 15, getdate())`

Obs: A tabela de agendamentos vai ser populada pelo FrontEnd

## Executando o projeto

1. Clone o projeto com o comando (https://github.com/consule/ControleDeSalasBackEnd.git) para uma pasta de sua preferencia. 
2. Abra a solução com o Visual Studio Community 2019 e execute;

## APIs do Projeto

###### Recupera as  salas existentes: 
GET `http://localhost:52611/api/Salas/`

```yaml
[
  {
     "id":1,
     "nome":"Reunião",
     "capacidade":"12",
     "dataCriacao":"2020-06-14T21:00:00"
  },
  {
     "id":2,
     "nome":"Oval",
     "capacidade":"45",
     "dataCriacao":"2020-06-14T21:00:00"
  }
]
```

###### Recupera os agendamentos  existentes:
GET
`http://localhost:52611/api/Agendamentos/`

```yaml
[
  {
    "id": 1,
    "idSala": 1,
    "titulo": "Briefing de Projeto",
    "dataHoraInicial": "2020-06-14T19:00:00",
    "dataHoraFinal": "2020-06-14T19:01:00"
  },
  {
    "id": 2,
    "idSala": 1,
    "titulo": "Sprint Review",
    "dataHoraInicial": "2020-06-14T20:00:00",
    "dataHoraFinal": "2020-06-14T21:00:00"
  },
  {
    "id": 3,
    "idSala": 1,
    "titulo": "Brainstorm",
    "dataHoraInicial": "2020-06-14T20:00:00",
    "dataHoraFinal": "2020-06-14T21:00:00"
  }
]
```

###### Recupera agendamentos existentes caso a tentativa de reserva esteja dentro do intervalo solicitado: 
GET FromBody

`http://localhost:52611/api/agendamentos/agendamentosExistentes`

#### Corpo da Solicitação: 

```yaml
{
    "idSala": 1, 
    "dataHoraInicial": "2020-06-14T20:10:00",
    "dataHoraFinal": "2020-06-14T20:58:00"
}
```

#### Retorno da API

```yaml
[
  {
    "id": 2,
    "idSala": 1,
    "titulo": "Reunião",
    "dataHoraInicial": "2020-06-14T20:00:00",
    "dataHoraFinal": "2020-06-14T21:00:00"
  }
]
```

###### Insere um agendamento:
POST
`http://localhost:52611/api/Agendamentos/`
#### Corpo da Solicitação: 
```yaml
 {
    "idSala": 1,
    "titulo": "Reunião Semanal com Equipe",
    "dataHoraInicial": "2020-06-14T19:00:00",
    "dataHoraFinal": "2020-06-14T20:01:00"
  },
```

