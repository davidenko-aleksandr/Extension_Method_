using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method
{
    public  class Road
    {
        public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number}, общей протяженностью {Lenght}";
        }
    }
}
