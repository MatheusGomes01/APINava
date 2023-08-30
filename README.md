# API de Pessoa

Esta é uma API de exemplo para gerenciar informações de pessoas. A API permite criar, atualizar, recuperar e excluir registros de pessoas.

## Configuração

Certifique-se de ter as seguintes ferramentas instaladas:

- [.NET Core SDK](https://dotnet.microsoft.com/download) versão 5.0
- [PostgreSQL](https://www.postgresql.org/download/) (ou outro banco de dados compatível, que seja compátivel com .net core 5.0)

## Configuração do Banco de Dados

1. Configure a string de conexão no arquivo `appsettings.json` para conectar-se ao banco de dados PostgreSQL.
2. Execute as migrações para criar as tabelas do banco de dados:
