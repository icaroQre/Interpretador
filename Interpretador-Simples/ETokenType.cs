namespace Translator{

    public enum ETokenType{

        ERR,

        // +
        SUM,  

        // -
        SUB,

        // *
        MULT,

        // /
        DIV,

        EOF,

        // \n\r
        EOL,

        // 'get'
        INPUT,

        // 'show'
        OUTPUT,

        // #[a-z]+
        VAR,

        // '='
        AT,         

        // '('
        OE,

        // ')'
        CE,

        // [0-9]
        NUM


    }

}
