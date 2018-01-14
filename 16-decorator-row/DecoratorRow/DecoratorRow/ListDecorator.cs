using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListDecorator : ColumnDecorator
    {
        public ListDecorator(IRow row, List<string> columns) : base(row, columns)
        {
        }

        // pepa, karel, viktor,martin

        protected override dynamic TransformGet(dynamic value)
        {
            //return new List<string>(value.Split(',')).Map(x => x.Trim());
            return new List<string>(value.Split(',')).Select(x => x.Trim());
        }

        protected override string TransformSet(dynamic value)
        {
            return String.Join(",", value);
        }
    }



    public static class ListExtensions
    {
        public static List<TOut> Map<TIn, TOut>(this List<TIn> data, Func<TIn, TOut> transform)
        {
            List<TOut> result = new List<TOut>();

            foreach (TIn item in data)
            {
                result.Add(transform(item));
            }

            return result;
        }
    }
}
