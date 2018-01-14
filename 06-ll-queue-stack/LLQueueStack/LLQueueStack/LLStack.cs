using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LLStack
    {
        private Item top = null;

        public void Push(int value)
        {
            Item i = new Item() { Value = value };

            if (this.top != null)
            {
                this.top.Next = i;
            }

            this.top = i;
        }

        public int Pop()
        {
            int value = this.Peek();
            this.top = this.top.Next;

            return value;
        }

        public int Peek()
        {
            return this.top.Value;
        }
    }
}
