# Interpretador-Simples

Um compilador escrito em C# que converte o código-fonte de uma linguagem de programação desejada para código assembly.

## Classes do Compilador

### ETokenType

Define os tipos de tokens suportados pelo compilador:

- **SUM**: Token de soma
- **DIV**: Token de divisão
- **MULT**: Token de multiplicação

### Lexer

É o leitor léxico do compilador, responsável por transformar o código-fonte em uma sequência de tokens. Cada token representa um elemento léxico, como palavras-chave, identificadores, números, operadores e símbolos especiais.

### SymbolTable

Gerencia a tabela de símbolos durante a análise léxica e sintática. Armazena informações sobre variáveis e outros símbolos identificados no código-fonte.

### TableEntry

Atua em conjunto com a `SymbolTable`. Cada `TableEntry` representa uma entrada na tabela de símbolos:

- **Type**: Tipo do símbolo, usando `ETokenType`.
- **Name**: Nome do símbolo.
- **Value**: Valor associado ao símbolo (quando aplicável).

### Token

Representa os tokens identificados na análise léxica:

- **Type**: Tipo do token, usando `ETokenType`.
- **Value**: Valor associado ao token (quando aplicável).

## Instalação

**Pré-requisitos**: Certifique-se de ter o ambiente .NET Core instalado em sua máquina.

## Execução
No terminal:

dotnet run text.txt
Conteúdo do arquivo txt:

1 + ((1 * 8)/(2-1))
r = 8
get #j
show #k
Nota: O usuário pode alterar os valores conforme desejado.
