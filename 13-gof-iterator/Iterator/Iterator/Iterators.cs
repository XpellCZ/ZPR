using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IMyIterator
    {
        bool HasNext();

        int GetNext();
    }

    public class MyListIterator : IMyIterator
    {
        private List<int> data = new List<int>();

        private int current = 0;

        public MyListIterator(List<int> data)
        {
            this.data = data;
        }

        public int GetNext()
        {
            return this.data[this.current++];
        }

        public bool HasNext()
        {
            return this.current < this.data.Count;
        }
    }
}
