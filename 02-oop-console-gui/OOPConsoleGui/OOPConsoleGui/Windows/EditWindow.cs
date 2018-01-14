using ConsoleApplication1.Components;
using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Windows
{
    public class EditWindow : Window
    {
        private Table _table;
        private int _tableIndex;

        public EditWindow(Application app, Table table, int index) : base(app)
        {
            this._table = table;
            this._tableIndex = index;

            Row row = table.Rows[index];

            int i = 0;
            foreach (string cell in row.Cells)
            {
                this._components.Add(new Textbox() {
                    Label = table.Header[i],
                    Value = cell,
                    Active = (i == 0)
                });
                i++;
            }
        }

        protected override Window OnSubmit()
        {
            int i = 0;
            foreach (Component component in this._components)
            {
                if (component is Textbox)
                {
                    Textbox t = component as Textbox;
                    this._table.Rows[this._tableIndex].Cells[i] = t.Value;
                    i++;
                }
            }


            return new ListWindow(this._application, this._table);
        }

        protected override Window OnEscape()
        {
            return new ListWindow(this._application, this._table);
        }
    }
}
