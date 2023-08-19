namespace  Translator{

    public class Lexer{
        
        public Int32 Line {get; protected set;}
        public Int32 Column {get; protected set;}
         
        public SymbolTable St {get; protected set;}

        private char? _peek;

        private readonly StreamReader _file;

        public Lexer(StreamReader file, SymbolTable? st = null){

            st ??= new SymbolTable();
            this.St = st;
            this._file = file;
            Column = 1;
            Line = 1;

        }

        public Token GetNextToken(){

            if(_file.EndOfStream)
                return new Token(ETokenType.EOF);

            while(_peek == null || _peek == ' ' || _peek == '\t' || _peek == '\r'){

                _peek = NextChar();
            
            }

            switch(_peek){
                case '+': _peek = null; return new Token(ETokenType.SUM);
                case '-': _peek = null; return new Token(ETokenType.SUB);
                case '*': _peek = null; return new Token(ETokenType.MULT);
                case '/': _peek = null; return new Token(ETokenType.DIV);
                case '(': _peek = null; return new Token(ETokenType.OE);
                case ')': _peek = null; return new Token(ETokenType.CE);
                case '=': _peek = null; return new Token(ETokenType.AT);
                case '\n':
                    _peek = null; 
                    Column = 1;
                    Line++;
                    return new Token(ETokenType.EOL); 
            }

            if(_peek == '#'){

                var varName = "";
                do{

                    _peek = NextChar();
                    if(Char.IsLetter(_peek.Value))
                        varName +=_peek;
                
                }while(Char.IsLetter(_peek.Value));

                var key = St.Insert(varName);

                return new Token(ETokenType.VAR, key);

            }

            if(_peek == 'g'){
                //get
                if(TestSuffix("et")){
                    return new Token(ETokenType.INPUT);
                }
            }

            if(_peek == 's'){
                //show
                if(TestSuffix("how")){
                    return new Token(ETokenType.OUTPUT);
                }
            }

            if(Char.IsDigit(_peek.Value)){
                var value = 0;
                do{
                    value = value * 10 + GetValue(_peek);
                    // Console.WriteLine(GetValue(_peek)+"-"+_peek);
                    _peek = NextChar();
                }while(Char.IsDigit(_peek.Value));

                return new Token(ETokenType.NUM, value);
            }

            return new Token(ETokenType.ERR);

        }

        public char NextChar(){
            Column++;
            Char c = '\0';
            if(!_file.EndOfStream)
                c = (Char) _file.Read();
            return c;
        }

        public bool TestSuffix(String suffix){
            var res = true;
            suffix.ToCharArray().ToList().ForEach(c => {
                _peek = NextChar();
                if(_peek != c){
                    res= false;
                    return;
                }
            });
            _peek = null;
            return res;
        }

        public static int GetValue(Char? c){
            if (c == '0') return 0;
            if (c == '1') return 1;
            if (c == '2') return 2;
            if (c == '3') return 3;
            if (c == '4') return 4;
            if (c == '5') return 5;
            if (c == '6') return 6;
            if (c == '7') return 7;
            if (c == '8') return 8;
            if (c == '9') return 9;

            return 0;
        }


    }

}