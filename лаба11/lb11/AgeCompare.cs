using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    public class AgeCompare : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null) throw new Exception("Не возможно сравнить");
            else
            {
                if (x.Vozrast() > y.Vozrast()) return 1;
                else if (x.Vozrast() < y.Vozrast()) return -1;
                else return 0;
            }
        }
    }
}
