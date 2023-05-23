using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    public class Node<T>
    {
        public Node(T data)
        {
            this.data = data;
        }
        public Node<T> next { get; set; }
        public Node<T> prev { get; set; }
        public T data { get; set; }
    }
}
