using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;  

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string[] Lines = File.ReadAllLines("Texto.txt");
            int nl = Lines.Count(LinkedList => Lines.Length > 30);
            Console.WriteLine($"Lines > 30 : {nl}");

            double AVG = Lines.Average(Line => Line.Length);
            Console.WriteLine($"Average chars : {AVG}");
            
            Console.WriteLine($"> 120? {Lines.Any(Line => Lines.Length > 120)}");

            IEnumerable<string> a = Lines.Where(Line => Line.Contains("Y")).Select(Line => Line.Trim().Split()[0].ToUpper());
            foreach(string s in a)
            {
                Console.WriteLine(s);
            }
        }
    } 
}
