using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2zadanie
{
    internal class Program
    {
        public static string[] SplitLine(string line)
        {
            string[] subs = line.Split(' ');
            return subs;
        }

        public static void ReversWords(string words)
        {
            string[] subs = SplitLine(words);
            for (int i = subs.Length -1; i >= 0; i--)
            {
                Console.Write(subs[i] + " ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение с пробелом после каждого слова");
            string line = Console.ReadLine();

            ReversWords(line);
        }
    }
}
