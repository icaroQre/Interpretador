namespace Translator{

    public class SymbolTable{

        public int _key = 0;
        public Dictionary<int, TableEntry> _data;

        public SymbolTable(){

            _data = new Dictionary<int, TableEntry>();

        }

        public Int32 Insert(string name){

            return this.Insert(name, null);

        }

        public Int32 Insert(string name, Double? value){

            var (entry, key) = GetByName(name);
            if(entry != null)
                return key;

            _data.Add(++_key, new TableEntry(ETokenType.VAR, name, value));
            return _key;

        }

        public (TableEntry?, Int32) GetByName(string name){
            foreach (var k in _data.Keys.ToList()){
                if (_data[k].Name == name)
                {
                    return (_data[k], k);
                }
            };
            return (null, 0);
        }

               public double? Get(Int32 key)
        {
            if (!(_data.ContainsKey(key)))
                return null;
            TableEntry entry = _data[key];
            return entry.Value;
        }


        public TableEntry? GetEntry(Int32 key)
        {
            if (!(_data.ContainsKey(key)))
                return null;
            TableEntry entry = _data[key];
            return entry;
        }

        
    


        

    }

}