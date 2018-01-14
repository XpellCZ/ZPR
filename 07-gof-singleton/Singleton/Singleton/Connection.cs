using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Connection
    {
        public static readonly Connection Instance = new Connection();

        private Connection()
        {

        }
    }
}
