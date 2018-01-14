using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyInfiniteStack : MyStack
    {
        protected override void OnFullStack()
        {
            int[] d = new int[this.data.Length << 1];   // * 2

            for (int i = 0; i < this.data.Length; i++)
            {
                d[i] = this.data[i];
            }

            this.data = d;
        }
    }
}
