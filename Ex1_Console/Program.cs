using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;

            Console.Write("Напишите строку: ");
            str = Console.ReadLine();

            int count = 0;
            foreach (char c in str)
                if (char.IsDigit(c)) count++;

            Console.WriteLine("Количество цифр в строке: " + count);
        }
    }
}
