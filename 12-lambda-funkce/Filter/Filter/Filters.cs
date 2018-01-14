using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IFilter<T>
    {
        bool Filter(T item);
    }


    public class EvenFilter : IFilter<int>
    {
        public bool Filter(int item)
        {
            return item % 2 == 0;
        }
    }
}
