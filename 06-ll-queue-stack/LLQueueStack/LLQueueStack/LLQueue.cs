using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LLQueue
    {
        private Item start = null;

        private Item end = null;

        public void Enqueue(int value)
        {
            Item i = new Item() { Value = value };

            if (this.end != null)
                this.end.Next = i;

            this.end = i;
        }

        public int Dequeue()
        {
            int value = this.Peek();

            this.start = this.start.Next;

            if (this.start == null)
                this.end = null;

            return value;
        }

        public int Peek()
        {
            return this.start.Value;
        }
    }
}
