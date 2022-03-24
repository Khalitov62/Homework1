using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cumle daxil edin");
            string word = Console.ReadLine();
            Console.WriteLine("Axtardiginiz sozu  daxil adin");
            string searched = Console.ReadLine();
            bool answer = word.customContains(searched);
            if (answer == true) Console.WriteLine("Soz var");
            else Console.WriteLine("Soz yoxdur");
        }
    }
}
