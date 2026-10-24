# Agenda de Contatos em C#

Aplicação de console desenvolvida em C# para gerenciamento de contatos, permitindo cadastrar, consultar, editar e excluir registros por meio de um menu interativo.

O projeto foi desenvolvido com o objetivo de praticar os fundamentos da linguagem C#, a manipulação de coleções e os conceitos iniciais de Programação Orientada a Objetos.

## Funcionalidades

- **Cadastro de contatos:** registra nome e telefone, atribuindo um identificador automático.
- **Listagem de contatos:** exibe os contatos cadastrados.
- **Busca por nome:** localiza contatos sem diferenciar letras maiúsculas e minúsculas.
- **Busca por ID:** consulta um contato pelo identificador.
- **Edição de contatos:** permite atualizar nome e telefone.
- **Exclusão de contatos:** remove um registro pelo ID.
- **Menu interativo:** disponibiliza as operações por meio do terminal.

## Tecnologias e conceitos aplicados

- C#
- .NET
- Classes, objetos e propriedades
- Coleções com `List<T>`
- Estruturas condicionais com `if/else` e `switch`
- Laços de repetição com `do-while` e `foreach`
- Manipulação de listas e operações de cadastro, consulta, atualização e exclusão (CRUD)

## Como executar

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Git](https://git-scm.com/downloads)

### Instalação e execução

1. Clone o repositório:

   ```bash
   git clone https://github.com/Ryan3103/agenda-contatos-csharp.git
   ```

2. Acesse a pasta do projeto:

   ```bash
   cd agenda-contatos-csharp/CadastroContatos
   ```

3. Execute a aplicação:

   ```bash
   dotnet run
   ```

## Observações

- Os contatos são armazenados em memória durante a execução.
- Os registros são perdidos quando a aplicação é encerrada.
- Os IDs são atribuídos automaticamente durante a execução.

## Objetivo do projeto

Consolidar os fundamentos de C# por meio da construção de uma aplicação funcional, exercitando a lógica de programação, a organização do código e a manipulação de objetos e coleções.

---

Desenvolvido por **Ryan Gabriel**.