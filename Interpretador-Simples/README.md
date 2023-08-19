# Interpretador-Simples
Compilador feito em C# que converte o codigo fonte em linguagem de programação desejada para codigo assembly. Abaixo, possui a descrição das classes do compilador.

# ETokenType
Define os tipos de tokens que esse compilador possui, alguns exemplos:
* SUM // Token de soma
* DIV // Token de divisão
* MULT // Token de multiplicação

# Lexer
É o leitor léxico do compilador, serve para analisar o codigo fonte e converte-lo em uma sequencia de tokens, que são unidades significativas da linguagem. Cada token representa um elemento léxico, como palavras chaves, identificadores, números, operadores e simbolos especias

# SymbolTable
A tabela de símbolos serve para gerenciar a tabela de símbolos durante o processo de análise léxica e sintática de um compilador. Ela permite que o compilador mantenha informações sobre variáveis e outros símbolos à medida que eles são encontrados no código-fonte, facilitando a análise subsequente e a geração de código intermediário ou código de máquina

# TableEntry
A tabela de entrada funciona juntamente com a tabela de símbolos para criar uma estrutura que armazena e gerencia informações sobre os símbolos presentes no programa sendo compilado. a TableEntry usada para representar as entradas individuais na tabela de símbolos em um compilador. Cada TableEntry contém informações relevantes sobre um símbolo específico encontrado no código-fonte, como o tipo do símbolo (variável, palavra-chave, número, etc.), o nome do símbolo e, opcionalmente, o valor associado a ele (no caso de números ou constantes).

Na classe TableEntry:

* Possui três propriedades: 'Type', 'Name' e 'Value'.
* 'Type' é uma propriedade que armazena o tipo do símbolo, usando a enumeração ETokenType.
* 'Name' é uma propriedade que armazena o nome do símbolo (por exemplo, o nome de uma variável ou palavra-chave).
* 'Value' é uma propriedade que armazena o valor associado ao símbolo, se for aplicável. No caso de variáveis numéricas ou constantes, isso pode representar o valor numérico da variável.

O construtor TableEntry permite criar instâncias dessa classe, especificando o tipo, nome e, opcionalmente, o valor do símbolo. Isso permite que a tabela de símbolos armazene informações sobre cada símbolo encontrado no código-fonte durante a análise léxica e sintática.

# Token
A classe Token é usada para representar os tokens individuais identificados durante o processo de análise léxica em um compilador. Cada Token contém informações relevantes sobre um token específico, como o tipo do token e, opcionalmente, um valor associado a ele.

na classe Token:

* Token é uma classe que possui duas propriedades: 'Type' e 'Value'.
* 'Type' é uma propriedade que armazena o tipo do token, usando a enumeração ETokenType. Isso indica o tipo do elemento léxico que o token representa, como um operador, uma palavra-chave, um número, etc.
* 'Value' é uma propriedade que armazena um valor associado ao token, se for aplicável. No seu caso, é um número inteiro que pode estar relacionado ao valor de um token, como um valor numérico associado a um número encontrado no código-fonte.

O construtor Token permite criar instâncias dessa classe, especificando o tipo e, opcionalmente, um valor para o token. Isso permite que o compilador armazene informações sobre cada token encontrado durante a análise léxica e use essas informações posteriormente durante a análise sintática e a geração de código intermediário ou assembly.

## Instalação
Pré-requisitos: Certifique-se de ter o ambiente .NET Core instalado em sua máquina.

```bash
$ git clone https://github.com/LeonardoFariaOliveira/Interpretador-Simples
$ cd Interpretador-Simples
```

## Running the compiler

* No terminal
```bash
dotnet run text.txt
```

* Arquivo txt
```bash
$ 1 + ((1 * 8)/(2-1))
r = 8
get #j
show #k
```

O usuário pode alterar os valores se desejar
