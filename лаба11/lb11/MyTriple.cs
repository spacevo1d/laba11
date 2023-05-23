using lb11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    public class MyTriple<T1,T2,T3> : MyPair<T1,T2>
    {
        private T3 c;
        public MyTriple(T1 first, T2 second, T3 third) : base(first, second)
        {
            this.c = third;
        }
        public override object this[int index]
        {
            get
            {
                if (index == 2) { return c; }
                else { return base[index]; };
            }
            set
            {
                if (index == 2) { c = (T3?)value; }
                else { base[index] = value; };
            }
        }
    }
}
