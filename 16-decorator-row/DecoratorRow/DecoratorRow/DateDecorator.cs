using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DateDecorator : ColumnDecorator
    {
        public DateDecorator(IRow row, List<string> columns) : base(row, columns)
        {
        }

        protected override dynamic TransformGet(dynamic value)
        {
            return DateTime.Parse(value);
        }

        protected override string TransformSet(dynamic value)
        {
            return value.ToString();
        }
    }
}
