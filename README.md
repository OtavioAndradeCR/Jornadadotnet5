# DevTrackR – API de Gerenciamento de Pacotes

## 📌 Visão Geral

O **DevTrackR** é uma **API REST desenvolvida em C# com .NET**, voltada para o gerenciamento de pacotes e atualizações. A aplicação permite cadastrar, consultar e atualizar informações, seguindo boas práticas de desenvolvimento backend e organização em camadas.

Este projeto foi desenvolvido com foco em **portfólio profissional**, demonstrando domínio da stack .NET e construção de APIs REST bem estruturadas.

---

## 🎯 Objetivo do Projeto

* Desenvolver uma API REST utilizando .NET
* Demonstrar uso de Entity Framework Core e boas práticas de backend
* Aplicar organização em camadas e separação de responsabilidades
* Servir como projeto demonstrativo para recrutadores

---

## 🛠️ Tecnologias Utilizadas

* **C#**
* **.NET / ASP.NET Core**
* **Web API REST**
* **Entity Framework Core**
* **Swagger / OpenAPI**
* **Injeção de Dependências**

---

## 🧱 Arquitetura

O projeto segue uma **arquitetura em camadas**, separando claramente as responsabilidades:

* **Controllers** – Camada de apresentação (endpoints da API)
* **Services / Application** – Regras de negócio
* **Domain / Entities** – Entidades do domínio
* **Infrastructure** – Persistência de dados e integrações

Essa estrutura facilita manutenção, testes e evolução da aplicação.

---

## ▶️ Como Executar o Projeto

### Pré-requisitos

* .NET SDK 6.0 ou superior
* Visual Studio ou VS Code

### Passos

```bash
# Clonar o repositório
git clone https://github.com/OtavioAndradeCR/Jornadadotnet5.git

# Acessar a pasta do projeto
cd Jornadadotnet5

# Restaurar dependências
dotnet restore

# Executar a aplicação
dotnet run
```

A aplicação estará disponível conforme a configuração padrão do ASP.NET Core.

---

## 📡 Endpoints Principais

```
GET    /api/packages
GET    /api/packages/{id}
POST   /api/packages
PUT    /api/packages/{id}
DELETE /api/packages/{id}
```

---

## 🧪 Exemplos de Uso (curl)

```bash
curl http://localhost:5000/api/packages
```

---

## 🧩 Diferenciais Técnicos

* Estrutura de projeto organizada e profissional
* Uso de Entity Framework Core para persistência
* Documentação automática com Swagger
* Base sólida para evolução da API

---

## 📈 Possíveis Evoluções

* Paginação e filtros nos endpoints
* Autenticação e autorização (JWT / Identity)
* Testes automatizados
* Deploy em nuvem (Azure)
