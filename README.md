# 🎶 Screen Sound - Backend API

## Descrição

**Screen Sound** é uma aplicação **back-end** desenvolvida em C# que simula uma plataforma de streaming musical. O sistema permite o gerenciamento de **bandas**, com foco exclusivo na estrutura e funcionamento do **back-end**, sem interface gráfica.

Este projeto foi criado com fins educacionais, para praticar conceitos como **programação orientada a objetos**, **estruturas de dados** e **interação com o usuário via terminal**.

## Funcionalidades

- ✅ Cadastrar bandas  
- ✅ Listar todas as bandas  
- ✅ Avaliar bandas  
- ✅ Exibir média de avaliação das bandas  
- ✅ Encerrar o programa

## Tecnologias utilizadas

- 💻 **C#**
- 🧠 .NET (console app)
- 📁 Armazenamento em memória (sem banco de dados)

## Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/screensound-backend.git
   ```

2. Acesse a pasta do projeto:
   ```bash
   cd screenSound
   ```

3. Execute o projeto:
   ```bash
   dotnet run
   ```

## Estrutura do Projeto

```
/ScreenSound
├── Program.cs
├── Models/
│   ├── Band.cs
│   ├── Music.cs
├── Services/
│   └── BandService.cs
├── Utils/
│   └── MenuHelper.cs
└── README.md
```

## Objetivo do Projeto

Este projeto tem como objetivo reforçar:

- 📌 Lógica de programação
- 📌 Estruturação de aplicações back-end
- 📌 Prática com menus interativos e entrada de dados via console
- 📌 Aplicação de conceitos de POO em C#
