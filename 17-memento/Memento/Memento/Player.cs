using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        public event Action OnMove;

        public int X { get; set; }

        public int Y { get; set; }

        public void MoveLeft()
        {
            this.OnMove();
            this.X--;
        }

        public void MoveRight()
        {
            this.OnMove();
            this.X++;
        }

        public void MoveUp()
        {
            this.OnMove();
            this.Y--;
        }

        public void MoveDown()
        {
            this.OnMove();
            this.Y++;
        }

        // memento

        public Memento CreateMemento()
        {
            return new Memento(this.X, this.Y);
        }

        public void Restore(Memento memento)
        {
            this.X = memento.X;
            this.Y = memento.Y;
        }
    }
}
