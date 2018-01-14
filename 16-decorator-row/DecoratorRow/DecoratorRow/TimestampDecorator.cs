using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TimestampDecorator : DateDecorator
    {
        public TimestampDecorator(IRow row) : base(row, new List<string>() { "updated" })
        {
        }

        public override void Save()
        {
            this.SetValue("updated", DateTime.Now);

            base.Save();
        }
    }
}
