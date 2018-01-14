using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Components
{
    public abstract class Component
    {
        public bool Active { get; set; }

        public abstract void OnKey(ConsoleKeyInfo info);

        public abstract void Render();
    }
}
