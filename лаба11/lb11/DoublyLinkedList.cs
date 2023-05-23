using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    public class DoublyLinkedList<T>
    {
        
        public Node<T> head;
        public Node<T> tail;
        public int count;
        public void Add(T data)
        {
            Node<T> node=new Node<T>(data);
            if (head == null) head = node;
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            node.next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.prev = node;
            count++;
        }
        public void Delete(T data)
        {
            Node<T> node=head;
            Node<T> temp = new Node<T>(data);
            if (count == 0)
            {
                throw new Exception("Нельзя удалить из пустого массива!!!");
            }
            for(int i = 0; i < count; i++)
            {
                if (!temp.data.Equals(node.data))
                {
                    node=node.next;
                }
                else
                {
                    Node<T> temp1 = node.next;
                    Node<T> temp2 = node.prev;
                    temp1.prev = temp2;
                    temp2.next = temp1;
                    node.prev = node.next = null;
                    count--;
                    break;
                }
            }
        }
        public T GetFisrt()
        {
            return head.data;
        }
        public T GetLast()
        {
            return tail.data;
        }
        public void showcount()
        {
            Console.WriteLine("Размер:"+count);
        }
        public void print()
        {
            Node<T> node = head;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; ++i)
            {
                sb.Append(node.data.ToString() + " ");
                node=node.next;
            }
            Console.WriteLine("Список: "+sb.ToString());
        }
    }
}
