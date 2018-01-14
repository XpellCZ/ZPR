using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EndQueue
    {
        private int start = 0;

        private int end = 0;

        private int[] data;

        public EndQueue(int size = 8)
        {
            this.data = new int[size];
        }

        public void Enqueue(int value)
        {
            if (this.IsFull())
                throw new IndexOutOfRangeException("Full queue");

            this.data[this.end] = value;

            this.end = (this.end + 1) % this.data.Length;
        }

        public int Dequeue()
        {
            int value = this.Peek();
            this.start = (this.start + 1) % this.data.Length;

            return value;
        }

        public int Peek()
        {
            if (this.IsEmpty())
                throw new IndexOutOfRangeException("Empty queue");

            return this.data[this.start];
        }

        public bool IsEmpty()
        {
            return this.start == this.end;
        }

        private bool IsFull()
        {
            return (this.end + 1) % this.data.Length == this.start;
        }
    }
}
