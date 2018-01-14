using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            try
            {
                Application app = new Application();
            
                while (true)
                {
                    Console.Clear();
                    app.Render();

                    ConsoleKeyInfo info = Console.ReadKey();
                    app.OnKey(info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
