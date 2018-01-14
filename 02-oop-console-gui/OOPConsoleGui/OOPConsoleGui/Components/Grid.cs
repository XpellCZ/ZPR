using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Components
{
    public class Grid : Component
    {
        private Table _table;

        private int _selectedIndex = 0;
        private int _start = 0;
        private int _count = 10;

        public Grid(Table table)
        {
            this._table = table;
        }

        public override void OnKey(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.UpArrow)
            {
                this.ScrollUp();
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                this.ScrollDown();
            }
        }

        public void ScrollUp()
        {
            if (this._selectedIndex > 0)
            {
                this._selectedIndex--;
            }
            else if (this._start > 0)
            {
                this._start--;
            }
        }

        public void ScrollDown()
        {
            // TODO: bug ve scrollovani
            if (this._selectedIndex < this._start + this._count - 1)
            {
                this._selectedIndex++;
            }
            else if (this._start < this._table.Rows.Count - 1)
            {
                this._start++;
            }
        }

        public int SelectedIndex()
        {
            return this._selectedIndex;
        }

        public override void Render()
        {
            this.RenderLine();
            this.RenderDataRow(this._table.Header);
            this.RenderLine();

            for (int i = this._start; i < this._start + this._count; i++)
            {
                Row row = this._table.Rows[i];
                this.RenderDataRow(row.Cells, i == this._start + this._selectedIndex);
            }

            this.RenderLine();
        }

        private void RenderLine()
        {
            int i = 0;
            foreach (string item in this._table.Header)
            {
                string line = "".PadLeft(this.ColumnWidth(i) + 2, '-');
                Console.Write($"|{line}");
                i++;
            }
            Console.WriteLine("|");
        }

        private void RenderDataRow(List<string> data, bool selected = false)
        {
            if (selected)
                Console.BackgroundColor = ConsoleColor.Blue;

            int i = 0;
            foreach (string item in data)
            {
                int width = this.ColumnWidth(i);
                Console.Write($"| {item.PadLeft(width)} ");
                i++;
            }
            Console.WriteLine("|");

            Console.ResetColor();
        }

        private int ColumnWidth(int index)
        {
            // TODO: dodelat cache
            int width = this._table.Header[index].Length;

            foreach (Row row in this._table.Rows)
            {
                if (row.Cells[index].Length > width)
                    width = row.Cells[index].Length;
            }

            return width;
        }
    }
}
