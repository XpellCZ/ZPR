using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class RowDecorator : IRow
    {
        protected IRow row;

        public RowDecorator(IRow row)
        {
            this.row = row;
        }

        public virtual dynamic GetValue(string key)
        {
            return this.row.GetValue(key);
        }

        public virtual void Save()
        {
            this.row.Save();
        }

        public virtual void SetValue(string key, dynamic value)
        {
            this.row.SetValue(key, value);
        }
    }
}
