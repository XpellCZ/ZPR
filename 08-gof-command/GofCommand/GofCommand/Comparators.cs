using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // interface

    public interface IComparator
    {
        // 1  = a > b
        // 0  = a == b
        // -1 = a < b
        int Compare(object a, object b);
    }


    // class

    public class AscNumComparator : IComparator
    {
        public int Compare(object a, object b)
        {
            int numA = Convert.ToInt32(a);
            int numB = Convert.ToInt32(b);

            if (numA == numB)
                return 0;

            return (numA > numB) ? 1 : -1;
        }
    }

    public class DescNumComparator : IComparator
    {
        public int Compare(object a, object b)
        {
            int numA = Convert.ToInt32(a);
            int numB = Convert.ToInt32(b);

            if (numA == numB)
                return 0;

            return (numA < numB) ? 1 : -1;
        }
    }
}
