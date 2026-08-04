# 📞 Help Desk Console

Sistema de gerenciamento de chamados desenvolvido em **C#** utilizando **.NET**, com arquitetura em camadas e aplicação dos princípios fundamentais de Programação Orientada a Objetos (POO).

O projeto foi desenvolvido com o objetivo de consolidar conhecimentos em C#, organização de código, separação de responsabilidades e boas práticas de desenvolvimento, simulando um sistema simples de abertura e gerenciamento de chamados técnicos.

---

## 🚀 Funcionalidades

- ✅ Abrir chamados
- ✅ Listar todos os chamados
- ✅ Buscar chamado por ID
- ✅ Fechar chamado
- ✅ Geração automática de ID
- ✅ Definição de prioridade utilizando Enums
- ✅ Definição automática do status inicial
- ✅ Validação de campos obrigatórios
- ✅ Validação de e-mail
- ✅ Validação da prioridade
- ✅ Tratamento de entradas inválidas utilizando `TryParse`

---

## 🛠 Tecnologias utilizadas

- C#
- .NET
- Programação Orientada a Objetos (POO)
- Console Application
- Git
- GitHub

---

## 🏛 Arquitetura

O projeto foi organizado em camadas para separar responsabilidades.

```text
Program
    │
    ▼
ChamadoService
    │
    ▼
ChamadoRepository
    │
    ▼
List<Chamado>
```

### Responsabilidade de cada camada

### Program

Responsável por interagir com o usuário através do Console, receber os dados de entrada e encaminhar as informações para a camada de serviço.

### Service

Contém as regras de negócio da aplicação, coordenando as operações realizadas sobre os chamados.

### Repository

Responsável pelo armazenamento e recuperação dos chamados da aplicação.

### Models

Representam as entidades do sistema.

### Enums

Responsáveis pela padronização dos Status e Prioridades dos chamados.

---

## 📂 Estrutura do projeto

```text
HelpDeskConsole
│
├── Models
│   └── Chamado.cs
│
├── Enums
│   ├── StatusChamado.cs
│   └── PrioridadeChamado.cs
│
├── Repository
│   └── ChamadoRepository.cs
│
├── Services
│   └── ChamadoService.cs
│
└── Program.cs
```

---

## ▶ Como executar

Clone o repositório:

```bash
git clone https://github.com/SEU-USUARIO/HelpDeskConsole.git
```

Entre na pasta do projeto:

```bash
cd HelpDeskConsole
```

Execute:

```bash
dotnet run
```

---

## 📚 Conceitos praticados

Durante o desenvolvimento deste projeto foram praticados conceitos como:

- Programação Orientada a Objetos
- Classes e Objetos
- Métodos
- Construtores
- Encapsulamento
- Enums
- Collections (`List<T>`)
- Estruturas de decisão (`if`, `switch`)
- Estruturas de repetição (`while`, `foreach`)
- Tratamento de entrada com `TryParse`
- Validação de dados
- Organização em camadas
- Separação de responsabilidades
- Versionamento com Git

---

## 🔮 Melhorias futuras

Algumas melhorias planejadas para versões futuras:

- Persistência utilizando SQL Server
- Entity Framework Core
- Minimal API
- Interface Web
- Autenticação de usuários
- Histórico de alterações dos chamados
- Filtros por Status e Prioridade

---

<img width="693" height="228" alt="image" src="https://github.com/user-attachments/assets/db7794ac-5427-4544-90f9-b66b14bf0b41" />


## 👨‍💻 Autor

**Joanderson Eustorgio Souza**

Desenvolvedor Back-end em formação, estudando C# e .NET com foco na construção de aplicações bem estruturadas, aplicando boas práticas de desenvolvimento e arquitetura de software.

LinkedIn:
[https://www.linkedin.com/in/joanderson-eustorgio-souza](https://www.linkedin.com/in/joanderson-souza/)
