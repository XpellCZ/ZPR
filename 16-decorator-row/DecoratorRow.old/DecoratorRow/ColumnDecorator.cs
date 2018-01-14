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

            if (this.HasColumn(key))
                return this.ConvertGet(value);

            return value;
        }

        public override void SetValue(string key, dynamic value)
        {
            if (this.HasColumn(key))
                value = this.ConvertSet(value);

            this.row.SetValue(key, value);
        }

        protected bool HasColumn(string key)
        {
            return this.columns.Contains(key);
        }

        protected abstract dynamic ConvertGet(string value);

        protected virtual string ConvertSet(dynamic value)
        {
            return Convert.ToString(value);
        }
    }
}
