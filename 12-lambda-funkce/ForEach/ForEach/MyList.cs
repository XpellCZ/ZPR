using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate void EachDelegate<T>(T item);

    public class MyList<T>
    {
        private List<T> list = new List<T>();

        public MyList(params T[] values)
        {
            foreach (T item in values)
            {
                this.list.Add(item);
            }
        }

        public void Add(T item)
        {
            this.list.Add(item);
        }

        public void Each(EachDelegate<T> func)
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                func(this.list[i]);
                aaa();
            }
        }
    }
}
