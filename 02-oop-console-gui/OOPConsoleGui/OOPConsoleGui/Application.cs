using ConsoleApplication1.Model;
using ConsoleApplication1.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Application
    {
        private Window _activeWindow;

        private Table _table;

        public Application()
        {
            this._table = new Table();

            // TODO: nadratovana cesta
            this._table.Load(@"C:\data.txt");

            this._activeWindow = new ListWindow(this, this._table);
        }

        public void OnKey(ConsoleKeyInfo info)
        {
            this._activeWindow.OnKey(info);
        }

        public void Render()
        {
            this._activeWindow.Render();
        }

        public void SwitchWindow(Window window)
        {
            this._activeWindow = window;
        }
    }
}
