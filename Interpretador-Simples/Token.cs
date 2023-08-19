namespace Translator{
    public class Token{
        
        public ETokenType Type { get; set; }
        public int? Value {get; set;}
        //<Type, Value>
        //<VAR, 0>
        public Token(ETokenType type, Int32 value = 0)
        {
            Type = type;
            Value = value;
        }

    }

}

