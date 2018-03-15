using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Record <T>
    {
        public int id { get; set; }
        public T val { get; set; }

        public List<string> columns { get; set; }
        public int columnNumber { get; private set; }
             
        public Record(int id){
            this.id = id;
        }

        public Record(int id, T val)
        {
            this.id = id;
            this.val = val;
        }

        public Record(string[] str, int column, T t)
        {
            columns = new List<string>(str);
            val = t;
            columnNumber = column;
            id = int.Parse(str[0]);
        }
    }
}
