# LexicalAnalyzer
Analisador Léxico para uma linguagem hipotética.
A partir de uma entrada, onde contem uma cadeia de caracteres, é gerado uma lista de lexemas+tokens.
Exemplo: "a = 34 / (3 + 5)", gera os seguintes lexemas+tokens.
- '=' → ASSIGNMENT
 -'34' → NUMBER
- '/' → OPERATOR_DIVISION
- '(' → DELIMITER_OPEN_PARENTHESES
- '3' → NUMBER
- '+' → OPERATOR_SUM
- '5' → NUMBER
- ')' → DELIMITER_CLOSE_PARENTHESES

## Como usar
Voce pode gerar um Nuget ou importar a referencia em uma aplicação de console, por exemplo, em seguida faça:

```
        static void Main(string[] args)
        {
            string codigo = "(a = 34 / (3 + 5)";

            Lexer lexer = new Lexer();
            IEnumerable<TokenDefinition> tokenDefinition = TokenDefinition.GetTokens();

            foreach (var token in tokenDefinition)
            {
                lexer.AddDefinition(token);
            }

            var tokens = lexer.Tokenize(source).ToList();
        }
```

O Analisador Léxico foi feito baseado em definições regulares que analisam os padrões do código de entrada e Autômatos Finitos que aceitam as definições regulares.

## Tecnologias implementadas:

- .NET Core 2.0
