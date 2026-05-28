# 🗂️ Task Manager API (.NET)

## 📌 Visão geral do projeto

A **Task Manager API** é uma solução backend desenvolvida em **.NET Web API**, orientada à gestão de tarefas com operações CRUD completas.

O projeto foi construído com foco em **boas práticas de engenharia de software, escalabilidade, DevOps e cloud deployment**, simulando um ambiente de produção real.

---

## 🎯 Objetivo

Fornecer uma API robusta para gestão de tarefas, permitindo:

- Criação de tarefas
- Atualização de tarefas
- Remoção de tarefas
- Consulta por ID
- Listagem completa

A solução foi desenhada para ser facilmente extensível e preparada para ambientes cloud.

---

## ⚙️ Stack tecnológica

- **Backend:** C# (.NET 6/7/8)
- **Framework:** ASP.NET Core Web API
- **ORM:** Entity Framework Core
- **Database:** SQL Server / Azure SQL Database
- **Containerização:** Docker
- **CI/CD:** Azure DevOps + GitHub Actions
- **Cloud:** Microsoft Azure
- **API Documentation:** Swagger / OpenAPI

---

## 🧱 Arquitetura do sistema

O projeto segue princípios modernos de engenharia de software:

- Arquitetura em camadas (Layered Architecture)
- Separação de responsabilidades (Separation of Concerns)
- Dependency Injection nativa do .NET
- Repository Pattern para abstração de dados
- Domain-driven design (base estrutural)
- Migrations controladas com EF Core

A estrutura foi pensada para garantir:

- Escalabilidade
- Testabilidade
- Manutenção simplificada
- Baixo acoplamento entre camadas

---

## 🗄️ Base de dados e migrations

A persistência de dados é gerida via **Entity Framework Core** com suporte a migrations versionadas.

- Versionamento incremental da base de dados
- Suporte a SQL Server local e Azure SQL
- Atualização controlada do schema

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
