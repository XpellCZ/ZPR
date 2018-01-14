using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Mrkev : PevneJidlo
    {
        protected override int KritickaTeplota()
        {
            return 90;
        }
    }
}
