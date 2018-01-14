using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sorter
    {
        public List<T> Sort<T>(List<T> data, IComparator<T> comp)
        {
            for (int j = 0; j < data.Count; j++)
            {
                for (int i = 0; i < data.Count - 1; i++)
                {
                    //if (data[i] > data[i + 1])
                    if (comp.AreWrong(data[i], data[i + 1]))
                    {
                        T tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                    }
                }
            }

            return data;
        }
    }
}
