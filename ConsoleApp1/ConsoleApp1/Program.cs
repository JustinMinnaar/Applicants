using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new DateTime(1969, 7, 31);
            var dToday = (DateTime.Now.Year * 12 + DateTime.Now.Month);
            var dBirthdate = (b.Year * 12 + b.Month);
            var yy = (dToday - dBirthdate) / 12;

            Console.WriteLine(yy);
        }
    }
}