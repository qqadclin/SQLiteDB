using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteLinkDBTest
{
    public class DataReader
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string DateTime { get; set; }


        public DataReader(int index,string name,int prie,string datatime)
        {
            Index = index;
            Name = name;
            Price = prie;
            DateTime = datatime;
        }
    }
}
