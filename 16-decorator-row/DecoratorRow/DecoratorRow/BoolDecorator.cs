using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoolDecorator : ColumnDecorator
    {
        public BoolDecorator(IRow row, List<string> columns) : base(row, columns)
        {
        }

        protected override dynamic TransformGet(dynamic value)
        {
            return Convert.ToBoolean(value);
        }
    }
}
