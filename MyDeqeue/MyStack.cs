using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDeqeue
{
    public class MyStack<T> : Stack<T>
    {
        public T data;
        public MyStack<T> next { get; set; }
        public MyStack<T> prev { get; set; }
        public MyStack(T Data)
        {
            this.data = Data;
        }
        public MyStack()
        {

        }


    }
}
