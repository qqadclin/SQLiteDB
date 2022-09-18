namespace SQLiteAccess
{
    public class DBContenter
    {
        public int Index { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public string DateTime { get; set; }

        public DBContenter(int index,string name,int price,string datetime)
        {
            Index = index;
            Name = name;
            Price = price;
            DateTime = datetime;
        }
    }
}