# Sistema de Gestão de Produtos

Aplicação de console desenvolvida em C# com o objetivo de praticar programação orientada a objetos, organização de código e operações de gerenciamento de produtos.

## Funcionalidades

- Cadastro de produtos
- Listagem de produtos
- Busca de produtos por ID
- Edição de produtos
- Exclusão de produtos

## Tecnologias

- C#
- .NET
- Git e GitHub

## Organização do projeto

O projeto está organizado em diretórios com responsabilidades distintas:

- **Entities:** contém as entidades do domínio, como `Product`.
- **DTOs:** contém objetos utilizados para transportar dados, como `ProductDto`.
- **Repositories:** concentra as operações de acesso e gerenciamento dos produtos.
- **UserInterface:** contém a lógica de interação com o usuário pelo console.
- **Program.cs:** ponto de entrada da aplicação.

## Como executar

1. Instale o SDK do .NET compatível com o projeto.
2. Clone este repositório.
3. Abra um terminal na pasta do repositório.
4. Execute:

```bash
dotnet run --project SistemaFinanceiro/FinancialSystem.csproj
```

## Armazenamento dos dados

Atualmente, os produtos são armazenados em memória. Portanto, os dados cadastrados não são persistidos após o encerramento da aplicação.

## Objetivo

Este projeto faz parte do meu processo de aprendizado e desenvolvimento de projetos práticos em C#. A aplicação será evoluída gradualmente conforme novas necessidades forem surgindo.