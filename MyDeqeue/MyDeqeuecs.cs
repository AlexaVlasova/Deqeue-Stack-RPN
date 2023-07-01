using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDeqeue
{
    public class MyDeqeue<T>
    {

        public MyStack<T> myDeque = new MyStack<T>();
        public MyStack<T> buffer = new MyStack<T>();

        public void CopyStack(MyStack<T> mainStack, MyStack<T> buffer)
        {
            buffer.Clear();
            foreach (T element in mainStack)
            {
                buffer.Push(element);
            }

        }
        public void PopFromEnd()
        {
            CopyStack(myDeque, buffer);
            buffer.Reverse();
            buffer.Pop();
            buffer.Reverse();
            CopyStack(buffer, myDeque);
        }
        public void PopFromStart()
        {
            myDeque.Pop();
        }
        public void AddToEnd(T Data)
        {
            CopyStack(myDeque, buffer);
            buffer.Reverse();
            buffer.Push(Data);
            buffer.Reverse();
            CopyStack(buffer, myDeque);

        }
        public void WatchLast()
        {
            Console.WriteLine($" last element: {myDeque.Last()}");
        }
        public void WatchFirst()
        {
            Console.WriteLine($" first element:{myDeque.Peek()}");
        }
        public void AddToStart(T Data)
        {
            myDeque.Push(Data);
        }

        public void Print()
        {
            foreach (T t in myDeque)
            {
                Console.Write(t + "\t");
            }
        }

        public void Clear()
        {
            myDeque.Clear();
            buffer.Clear();
        }

        public void EmptyCheck()
        {
            if (myDeque.Count == 0)
            {
                Console.WriteLine("Deque is empty");
            }
            else
            {
                Console.WriteLine("Deque has elements");
            }
        }
    
    }
}
