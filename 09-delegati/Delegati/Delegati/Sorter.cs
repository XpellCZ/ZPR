using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate bool CompareDelegate(object a, object b);


    public class Sorter
    {
        public List<int> Sort(List<int> data, CompareDelegate comp)
        {
            for (int j = 0; j < data.Count; j++)
            {
                for (int i = 0; i < data.Count - 1; i++)
                {
                    //if (data[i] > data[i + 1])
                    if (comp(data[i], data[i + 1]))
                    {
                        int tmp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = tmp;
                    }
                }
            }

            return data;
        }
    }
}
