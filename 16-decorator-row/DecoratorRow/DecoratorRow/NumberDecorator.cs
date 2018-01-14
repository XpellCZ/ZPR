using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberDecorator : ColumnDecorator
    {
        public NumberDecorator(IRow row, List<string> columns) : base(row, columns)
        {
        }

        protected override dynamic TransformGet(dynamic value)
        {
            return Convert.ToInt32(value);
        }
    }
}
