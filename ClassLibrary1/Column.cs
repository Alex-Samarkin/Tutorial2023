using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Column
    {
        public Head Head { get; set; } = new Head();
        public Items Items { get; set; } = new Items();
    }
}
