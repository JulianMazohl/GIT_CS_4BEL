using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//**Programm zum umwandeln in verschiedene Zahlensysteme
namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {

            Titel("Das ist ein Test");

            Console.ReadKey();
        }

        static void Titel(string text)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(text);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
        }
    }
}
