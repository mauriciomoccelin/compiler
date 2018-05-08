# LexicalAnalyzer

 ## Analisador Léxico para uma linguagem hipotética.
 A partir de uma entrada, onde contem uma cadeia de caracteres, é gerado uma lista de lexemas+tokens.
 Exemplo: "var resultado = (34 / (3 + 5)", gera os seguintes lexemas+tokens.
- 'var' → RESERVED_WORD_VAR
- 'resultado' → IDENTIFIER
- '=' → ASSIGNMENT
- '34' → NUMBER
- '/' → OPERATOR_DIVISION
- '(' → DELIMITER_OPEN_PARENTHESES
- '3' → NUMBER
- '+' → OPERATOR_SUM
- '5' → NUMBER
- ')' → DELIMITER_CLOSE_PARENTHESES

## Como usar

 Disponível em: [Nuget](https://www.nuget.org/packages/LexicalAnalyzer/1.0.0/)
 Install into your PCL project and Client projects.

```
        static void Main(string[] args)
        {
            string codigo = "var teste = (34 / (3.5 + 5^2) ." +
                            "if (34 >= 5) { return; }";

            Lexer lexer = new Lexer();
            IEnumerable<TokenDefinition> tokenDefinition = TokenDefinition.GetTokens();

            foreach (var token in tokenDefinition)
            {
                lexer.AddDefinition(token);
            }

            var tokens = lexer.Tokenize(codigo).ToList();

            foreach (var item in tokens)
            {
                Console.WriteLine(item.ToString());
            }

            Console.Read();
        }
```

 O Analisador Léxico foi feito baseado em definições regulares que analisam os padrões do código de entrada e Autômatos Finitos que aceitam as definições regulares.

## Tecnologias implementadas:

 .NET Core 2.0

### Sobre:
 Desenvolvido por [Mauricio Moccelin](https://www.linkedin.com/in/mauriciomoccelin/) sobre [Licença](https://www.gnu.org/licenses/licenses.pt-br.html).
