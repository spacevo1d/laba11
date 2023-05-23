using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    public class MyPair<T1,T2>
    {
        private T1 a;
        private T2 b;
        public MyPair(T1 first, T2 second)
        {
            this.a = first;
            this.b = second;
        }
        virtual public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return a;
                }
                else if (index == 1)
                {
                    return b;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index", "Index must be either 0 or 1.");
                }
            }
            set
            {
                if (index == 0)
                {
                    a = (T1?)value;
                }
                else if (index == 1)
                {
                    b = (T2?)value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index", "Index must be either 0 or 1.");
                }
            }
        }
    }

}
