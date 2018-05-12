using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LexicalAnalyzer
{
    public class TokenDefinition
    {
        public bool IsIgnored { get; private set; }
        public Regex Regex { get; private set; }
        public string Type { get; private set; }

        public TokenDefinition()
        {
        }

        public TokenDefinition(string type, Regex regex): this(type, regex, false)
        {
        }

        public TokenDefinition(string type, Regex regex, bool isIgnored)
        {
            Type = type;
            Regex = regex;
            IsIgnored = isIgnored;
        }

        public static IEnumerable<TokenDefinition> GetTokens()
        {
            List<TokenDefinition> tokens = new List<TokenDefinition>();

            #region Numeric

            tokens.Add(new TokenDefinition("DECIMAL", new Regex(@"\d+(\.\d{1,2})m?")));
            tokens.Add(new TokenDefinition("NUMBER", new Regex(@"\d+")));

            #endregion

            #region Operator Tokens

            tokens.Add(new TokenDefinition("OPERATOR_POTENTIATION", new Regex(@"\^")));
            tokens.Add(new TokenDefinition("OPERATOR_SUM", new Regex(@"\+")));
            tokens.Add(new TokenDefinition("OPERATOR_SUBTRACTION", new Regex(@"\-")));
            tokens.Add(new TokenDefinition("OPERATOR_MULTIPLICATION", new Regex(@"\*")));
            tokens.Add(new TokenDefinition("OPERATOR_DIVISION", new Regex(@"\/")));
            tokens.Add(new TokenDefinition("ASSIGNMENT", new Regex(@"\=")));

            #endregion

            #region Relational Operators

            tokens.Add(new TokenDefinition("OPERATOR_EQUAL", new Regex(@"[==]+")));
            tokens.Add(new TokenDefinition("OPERATOR_LESS_EQUAL", new Regex(@"[<=]+")));
            tokens.Add(new TokenDefinition("OPERATOR_GREATER_EQUAL", new Regex(@"[>=]+")));
            tokens.Add(new TokenDefinition("OPERATOR_BIGGER", new Regex(@"\>")));
            tokens.Add(new TokenDefinition("OPERATOR_SMALLER", new Regex(@"\<")));

            #endregion

            #region Special Characters

            tokens.Add(new TokenDefinition("SPACE", new Regex(@"\' '"), true));
            tokens.Add(new TokenDefinition("TAB", new Regex(@"\t+")));
            tokens.Add(new TokenDefinition("LINE_BREACK", new Regex(@"\n]+")));
            tokens.Add(new TokenDefinition("TAB", new Regex(@"\s+"), true));
            tokens.Add(new TokenDefinition("LINE_BREACK", new Regex(@"\d+")));

            #endregion

            #region Delimiters

            tokens.Add(new TokenDefinition("DELIMITER_OPEN_KEY", new Regex(@"\{")));
            tokens.Add(new TokenDefinition("DELIMITER_CLOSE_KEY", new Regex(@"\}")));

            tokens.Add(new TokenDefinition("DELIMITER_OPEN_PARENTHESES", new Regex(@"\(")));
            tokens.Add(new TokenDefinition("DELIMITER_CLOSE_PARENTHESES", new Regex(@"\)")));

            tokens.Add(new TokenDefinition("DELIMITER_OPEN_BRACKETS", new Regex(@"\[")));
            tokens.Add(new TokenDefinition("DELIMITER_CLOSE_BRACKETS", new Regex(@"\]")));

            tokens.Add(new TokenDefinition("DELIMITER_DOT", new Regex(@"\.")));
            tokens.Add(new TokenDefinition("DELIMITER_COMMA", new Regex(@"\,")));
            tokens.Add(new TokenDefinition("DELIMITER_SEMICOLON", new Regex(@"\;")));

            #endregion

            #region Reserved Words

            tokens.Add(new TokenDefinition("RESERVED_WORD_VAR", new Regex(@"var")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_WHILE", new Regex(@"while")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_FOR", new Regex(@"for")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_IF", new Regex(@"if")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_ELSE", new Regex(@"else")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_SWITCH", new Regex(@"switch")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_CASE", new Regex(@"case")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_RETURN", new Regex(@"return")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_ARRAY", new Regex(@"array")));
            tokens.Add(new TokenDefinition("RESERVED_WORD_FUNCTION", new Regex(@"function")));

            #endregion

            #region Identifiers

            tokens.Add(new TokenDefinition("IDENTIFIER", new Regex(@"[A-Za-z_][a-zA-Z0-9_]+")));

            #endregion

            #region Types

            tokens.Add(new TokenDefinition("TYPE_INT", new Regex(@"int")));
            tokens.Add(new TokenDefinition("TYPE_REAL", new Regex(@"real")));

            #endregion

            return tokens;
        }
    }
}