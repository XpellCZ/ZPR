using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finder f = new Finder();
            f.Complete += () => { Console.WriteLine("Complete"); };
            f.Found += (FileInfo file) => { Console.WriteLine($"Found: {file.FullName}"); };
            f.Error += (DirectoryInfo directory) => { Console.WriteLine($"Error: {directory.FullName}"); };

            f.Find("aaa", @"C:\users");

            Console.ReadLine();
        }
    }
}
