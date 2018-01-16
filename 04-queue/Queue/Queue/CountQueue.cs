using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CountQueue
    {
        private int start = 0;

        private int count = 0;

        private int[] data;

        public CountQueue(int size = 8)
        {
            this.data = new int[size];
        }

        public void Enqueue(int value)
        {
            if (this.IsFull())
                throw new IndexOutOfRangeException("Full queue");

            this.data[(this.start + this.count) % this.data.Length] = value;
            this.count++;
        }

        public int Dequeue()
        {
            int value = this.Peek();
            this.start = (this.start + 1) % this.data.Length;
            this.count--;

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
            return this.count == 0;
        }

        private bool IsFull()
        {
            return this.count == this.data.Length;
        }
    }
}
