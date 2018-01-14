using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SingleLinkedList<T>
    {
        private LLItem first = null;

        private LLItem last = null;

        public void Add(T value)
        {
            LLItem i = new LLItem() { Value = value };

            if (this.first == null)
                this.first = i;
            else
                this.last.Next = i;

            this.last = i;
        }

        public T Get(int index)
        {
            return this.GetItem(index).Value;
        }

        public void Set(int index, T value)
        {
            this.GetItem(index).Value = value;
        }


        // indexer
        public T this[int index]
        {
            get {
                return this.GetItem(index).Value;
            }
            set {
                this.GetItem(index).Value = value;
            }
        }


        public void Insert(int index, T value)
        {
            LLItem n = new LLItem() { Value = value };

            if (index > 0)
            {
                LLItem x = this.GetItem(index - 1);
                n.Next = x.Next;
                x.Next = n;

                if (n.Next == null)
                    this.last = n;
            }
            else
            {
                n.Next = this.first;
                this.first = n;
            }
        }

        public void Clear()
        {
            this.first = this.last = null;
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                this.first = this.first.Next;

                if (this.first == null)
                    this.last = null;
            }
            else
            {
                LLItem x = this.GetItem(index - 1);
                x.Next = x.Next.Next;

                if (x.Next == null)
                    this.last = x;
            }
        }

        private LLItem GetItem(int index)
        {
            LLItem x = this.first;

            for (int i = 0; i < index; i++)
            {
                x = x.Next;
            }

            return x;
        }



        private class LLItem
        {
            public T Value { get; set; }

            public LLItem Next { get; set; }
        }
    }
}
