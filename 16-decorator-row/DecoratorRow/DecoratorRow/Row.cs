using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Row : IRow
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();

        public dynamic GetValue(string key)
        {
            return this.data[key];
        }

        public void SetValue(string key, dynamic value)
        {
            this.data[key] = Convert.ToString(value);
        }

        public void Save()
        {
            foreach (string item in this.data.Keys)
            {
                Console.WriteLine($"{item} => {this.data[item]}");
            }
        }
    }
}
