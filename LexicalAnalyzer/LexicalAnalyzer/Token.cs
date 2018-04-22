namespace LexicalAnalyzer
{
    public class Token
    {
        public Token(string type, string value, TokenPosition position)
        {
            Type = type;
            Value = value;
            Position = position;
        }

        public TokenPosition Position { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"Token: Type: {Type}, Value: {Value}, Position => Index: {Position.Index}, Line: {Position.Line}, Column: {Position.Column}";
        }
    }
}