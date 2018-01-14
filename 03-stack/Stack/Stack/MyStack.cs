using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack
    {
        protected int[] data;

        protected int top = 0;

        public MyStack(int size = 4)
        {
            this.data = new int[size];
        }

        public void Push(int value)
        {
            if (this.top == this.data.Length)
                this.OnFullStack();

            this.data[this.top++] = value;
        }

        public int Pop()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException("Empty stack");

            return this.data[--this.top];
        }

        public int Peek()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException("Empty stack");

            return this.data[this.top - 1];
        }

        public bool IsEmpty()
        {
            return this.top == 0;
        }

        protected virtual void OnFullStack()
        {
            throw new IndexOutOfRangeException("Full stack");
        }

    }
}
