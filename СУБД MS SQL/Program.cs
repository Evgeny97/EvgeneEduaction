using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СУБД_MS_SQL
{
    public class Description
    {
        public int id;
        public string id_p;
        public string name;
        public string myvalue;
        public string id_t;
        public string stage;
        public string diagnosis;

        public override string ToString()
        {
            return Convert.ToString(id) + "  " + id_p + "  " + name
                + "  " + myvalue + "  " + id_t + "  " + stage + "  " + diagnosis;
        }

    }
}