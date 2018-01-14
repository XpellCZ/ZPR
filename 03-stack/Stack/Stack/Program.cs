using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyInfiniteStack();

            /*s.Push(1);
            s.Push(2);
            Console.WriteLine(s.Peek());    // 2
            Console.WriteLine(s.Pop());     // 2
            Console.WriteLine(s.Peek());    // 1

            s.Push(3);
            Console.WriteLine(s.Pop());     // 3
            Console.WriteLine(s.Pop());     // 1
            s.Pop(); // ex*/

            for (int i = 0; i < 50; i++)
            {
                s.Push(i);
            }

            Console.ReadLine();
        }
    }
}
