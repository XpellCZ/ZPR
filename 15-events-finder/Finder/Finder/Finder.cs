using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void CompleteDelegate();

    public delegate void ErrorDelegate(DirectoryInfo directory);

    public delegate void FoundDelegate(FileInfo file);

    public class Finder
    {
        public event FoundDelegate Found;

        public event ErrorDelegate Error;

        public event CompleteDelegate Complete;


        public void Find(string text, string dir)
        {
            this.SearchDir(text, new DirectoryInfo(dir));
            this.Complete?.Invoke();
        }

        private void SearchDir(string text, DirectoryInfo dir)
        {
            try
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    this.SearchDir(text, subdir);
                }

                foreach (FileInfo item in dir.GetFiles())
                {
                    if (Regex.IsMatch(item.Name, text))
                        this.Found?.Invoke(item);
                }
            }
            catch (Exception ex)
            {
                this.Error?.Invoke(dir);
            }
        }
    }
}
