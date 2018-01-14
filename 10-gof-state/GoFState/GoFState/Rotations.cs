using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UpRotation : IRotation
    {
        public void Draw()
        {
            Console.WriteLine("^");
        }
    }

    public class DownRotation : IRotation
    {
        public void Draw()
        {
            Console.WriteLine("v");
        }
    }

    public class LeftRotation : IRotation
    {
        public void Draw()
        {
            Console.WriteLine("<");
        }
    }

    public class RightRotation : IRotation
    {
        public void Draw()
        {
            Console.WriteLine(">");
        }
    }
}
