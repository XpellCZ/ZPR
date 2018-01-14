using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IComparator<T>
    {
        bool AreWrong(T a, T b);
    }


    public class AscComparator : IComparator<int>
    {
        public bool AreWrong(int a, int b)
        {
            return a > b;
        }
    }

    public class DescComparator : IComparator<int>
    {
        public bool AreWrong(int a, int b)
        {
            return a < b;
        }
    }

    public class PersonComparator : IComparator<Person>
    {
        public bool AreWrong(Person a, Person b)
        {
            return a.Age > b.Age;
        }
    }

}
