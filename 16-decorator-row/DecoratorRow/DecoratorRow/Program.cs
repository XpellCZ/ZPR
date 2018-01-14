using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IRow row = new TimestampDecorator(
                            new ListDecorator(
                                new DateDecorator(
                                    new NumberDecorator(
                                        new Row(),
                                        new List<string>() { "age" }
                                    ),
                                    new List<string>() { "birthdate" }
                                ),
                                new List<string>() { "friends" }
                           )
                        );

            row.SetValue("name", "pepa");
            row.SetValue("age", 10);
            row.SetValue("birthdate", DateTime.Now);
            row.SetValue("friends", new List<string>() { "karel", "viktor", "martin" });


            object name = row.GetValue("name");
            object age = row.GetValue("age");
            object birthdate = row.GetValue("birthdate");
            object friends = row.GetValue("friends");

            row.Save();

            Console.ReadLine();
        }
    }
}
