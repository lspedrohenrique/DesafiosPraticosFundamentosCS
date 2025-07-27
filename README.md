# Desafios Práticos: Fundamentos do C#

## Sobre o Projeto

Este repositório documenta minha jornada de estudos nos fundamentos da linguagem C#, através da resolução de 6 desafios práticos baseados nos exercícios propostos pela [Rocketseat](https://www.rocketseat.com.br/). O objetivo é a aplicação e solidificação dos conhecimentos na linguagem e na plataforma .NET.

## Tecnologias Utilizadas

* **Linguagem:** C#
* **Plataforma:** .NET
* **IDE:** Visual Studio

## Estrutura dos Projetos

A solução está organizada em 6 projetos independentes, cada um focado em um conjunto específico de habilidades:

#### 1. Saudacao
Um programa simples para praticar a entrada e saída de dados no console.
* **Conceitos praticados:** `Console.ReadLine()`, `string.IsNullOrWhiteSpace()`, operador ternário (`? :`), interpolação de strings.

#### 2. NomeCompleto
Um projeto para concatenar strings e aplicar validações de entrada.
* **Conceitos praticados:** Validação com `string.IsNullOrWhiteSpace()`, remoção de espaços com `Trim()`.

#### 3. MatematicaBasicaEntreDoisValores
Uma calculadora básica que introduz uma estrutura mais robusta e a separação de responsabilidades.
* **Conceitos praticados:** Validação de números com `double.TryParse()`, `switch case`, separação da lógica em uma classe estática, e um loop de aplicação com `do-while`.

#### 4. ContadorDeCaracteres
Um programa para manipulação de strings e contagem de caracteres com base na escolha do usuário.
* **Conceitos praticados:** Métodos de string como `Replace()` e `Length`, validação de entrada com `while` e `Console.ReadKey()`.

#### 5. ValidadorDePlacaAntiga
Um validador de placas veiculares com foco na validação de dados e manipulação de strings.
* **Conceitos praticados:** Criação de um método de validação dedicado, normalização de dados com `ToUpper()` e `Trim()`, e validação de caracteres com `foreach` e `char.IsLetter()`/`char.IsNumber()`.

#### 6. DataFormatada
Um programa que explora o uso de tipos nativos do .NET para exibição de datas e horas.
* **Conceitos praticados:** Uso da struct `DateTime` e seus especificadores de formato padrão (`"d"`, `"D"`, `"F"`, `"T"`) para exibir a data e hora de diferentes maneiras.

## Autor

* **Pedro Henrique**
* **GitHub:** [@lspedrohenrique](https://github.com/lspedrohenrique)

## Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE.txt](LICENSE.txt) para mais detalhes.
