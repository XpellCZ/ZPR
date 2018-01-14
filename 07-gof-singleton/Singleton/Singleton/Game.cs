using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private static Game instance = null;

        private Game()
        {
        }

        public static Game GetInstance()
        {
            if (Game.instance == null)
                Game.instance = new Game();

            return Game.instance;
        }
    }
}
