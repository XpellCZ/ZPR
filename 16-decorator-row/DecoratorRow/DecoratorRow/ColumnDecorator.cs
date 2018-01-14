using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class ColumnDecorator : RowDecorator
    {
        protected List<string> columns = new List<string>();

        public ColumnDecorator(IRow row, List<string> columns) : base(row)
        {
            this.columns = columns;
        }


        public override dynamic GetValue(string key)
        {
            dynamic value = this.row.GetValue(key);

            if (this.columns.Contains(key))
                value = this.TransformGet(value);

            return value;
        }

        public override void SetValue(string key, dynamic value)
        {
            if (this.columns.Contains(key))
                value = this.TransformSet(value);

            this.row.SetValue(key, value);
        }


        protected virtual dynamic TransformGet(dynamic value)
        {
            return value;
        }

        protected virtual string TransformSet(dynamic value)
        {
            return Convert.ToString(value);
        }
    }
}
