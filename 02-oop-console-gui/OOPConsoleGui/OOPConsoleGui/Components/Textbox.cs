using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1.Components
{
    public class Textbox : Component
    {
        private const int MAX_LENGTH = 15;

        public string Label { get; set; }

        public string Value { get; set; }

        public override void OnKey(ConsoleKeyInfo info)
        {
            if (info.Key == ConsoleKey.Backspace && !String.IsNullOrEmpty(this.Value))
                this.Value = this.Value.Substring(0, this.Value.Length - 1);

            else //if (Regex.IsMatch(info.KeyChar.ToString(), "^[a-zA-Z0-9]$"))
                this.Value += info.KeyChar;

            if (this.Value.Length > MAX_LENGTH)
                this.Value = this.Value.Substring(0, MAX_LENGTH);
        }

        public override void Render()
        {
            if (this.Active)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(this.Label + ":");
            Console.WriteLine(this.Value.PadRight(MAX_LENGTH, '_'));
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}

