using System;
using System.Globalization;
using ResxHelper;

namespace ResxTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Resources.Culture = new CultureInfo("ja-JP");
            Console.WriteLine($"日本語：{Resources.HellowWorld}");

            Resources.Culture = new CultureInfo("en-US");
            Console.WriteLine($"英語：{Resources.HellowWorld}");
        }
    }
}
