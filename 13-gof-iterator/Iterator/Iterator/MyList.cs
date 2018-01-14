using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyList : IEnumerable<int>
    {
        private List<int> data = new List<int>();

        public MyList(params int[] data)
        {
            foreach (int item in data)
            {
                this.data.Add(item);
            }
        }

        public void Add(int value)
        {
            this.data.Add(value);
        }

        
        // Iterator

        public IMyIterator GetIterator()
        {
            return new MyListIterator(this.data);
        }


        // IEnumerable

        public IEnumerator<int> GetEnumerator()
        {
            return new MyListEnumerator(this.data);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyListEnumerator(this.data);
        }


        public class MyListEnumerator : IEnumerator<int>
        {
            private List<int> data = new List<int>();

            private int current = -1;

            public MyListEnumerator(List<int> data)
            {
                this.data = data;
            }


            public int Current => this.data[this.current];

            public int CurrentReal {
                get {
                    return this.data[current];
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                this.current++;
                return this.current < this.data.Count;
            }

            public void Reset()
            {
                this.current = -1;
            }
        }
    }
}
