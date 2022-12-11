using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.Write("Введите предложение: ");
                str = Console.ReadLine();

                if (str == "") continue;
                break;
            }

            foreach (char c in str)
                if (char.IsPunctuation(c)) sb.Append(" ");
                else sb.Append(c);

            string[] words = sb.ToString().Split(' ');
            List<string> result = new List<string>();

            string min = words[0];
            foreach (string word in words)
                if (word.Length < min.Length && word != "") min = word;

            foreach (string word in words)
                if (word.Length == min.Length) result.Add(word);

            if (result.Count == 0)
                Console.WriteLine("Строка пуста!");
            else if (result.Count == 1)
                Console.WriteLine($"Самое короткое слово: {result[0]}");
            else
            {
                Console.WriteLine("Самые короткие слова: ");
                foreach (string word in result) Console.WriteLine(word);
            }    
        }
    }
}
