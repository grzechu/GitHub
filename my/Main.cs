using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WprowadŸ liczbê");
            string liczba = Console.ReadLine();
            Console.WriteLine("Twoja liczba to: {0}", liczba);

            Console.WriteLine("Aby kontunuowaæ naciœnij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
