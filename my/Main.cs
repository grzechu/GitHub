using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowad� liczb�");
            string liczba = Console.ReadLine();
            Console.WriteLine("Twoja liczba to: {0}", liczba);

            Console.WriteLine("Aby kontunuowa� naci�nij dowolny klawisz...");
            Console.ReadKey();
        }
    }
}
