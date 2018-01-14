using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // interface

    public interface ISimpleComparator
    {
        bool AreWrong(object a, object b);
    }


    // class

    public class SimpleAscNumComparator : ISimpleComparator
    {
        public bool AreWrong(object a, object b)
        {
            int numA = Convert.ToInt32(a);
            int numB = Convert.ToInt32(b);

            return numA > numB;
        }
    }

    public class SimpleDescNumComparator : ISimpleComparator
    {
        public bool AreWrong(object a, object b)
        {
            int numA = Convert.ToInt32(a);
            int numB = Convert.ToInt32(b);

            return numA < numB;
        }
    }
}
