using ConsoleApplication1.Components;
using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Windows
{
    public class ListWindow : Window
    {
        private Table _table;

        private Grid _grid;

        public ListWindow(Application app, Table table) : base(app)
        {
            this._table = table;
            this._grid = new Grid(table) { Active = true };

            this._components.Add(this._grid);
        }

        protected override Window OnSubmit()
        {
            return new EditWindow(this._application, this._table, this._grid.SelectedIndex());
        }

        protected override Window OnEscape()
        {
            return this;
        }
    }
}
