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
            int breite = Console.WindowWidth;
            int textlen = text.Length;
            Console.Clear();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
            
            for (int i = 0; i < (breite-textlen)/2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("-");
            }
        }
    }
}
