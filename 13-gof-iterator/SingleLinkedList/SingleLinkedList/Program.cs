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
            SingleLinkedList<int> list = new SingleLinkedList<int>();

            for (int i = 0; i < 10; i++)
                list.Add(i);


            IIterator<int> iterator = list.GetIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.GetNext());
            }

            Console.WriteLine("----");

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
