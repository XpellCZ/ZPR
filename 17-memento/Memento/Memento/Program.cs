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
            Stack<Memento> caretaker = new Stack<Memento>();
            Player p = new Player() { X = 10, Y = 10 };

            p.OnMove += () => { caretaker.Push(p.CreateMemento()); };

            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write("x");

                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.Backspace:
                        if (caretaker.Count > 0)
                            p.Restore(caretaker.Pop());

                        continue;

                    case ConsoleKey.LeftArrow:
                        p.MoveLeft();
                        break;
                    case ConsoleKey.UpArrow:
                        p.MoveUp();
                        break;
                    case ConsoleKey.RightArrow:
                        p.MoveRight();
                        break;
                    case ConsoleKey.DownArrow:
                        p.MoveDown();
                        break;
                }
            }
        }
    }
}
