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

            Titel("Das ist ein Test", ConsoleColor.Red);
            Console.WriteLine("Das ist das Programm");
            Console.ReadKey();
        }

        static void Titel(string text, ConsoleColor textfarbe)
        {
            ConsoleColor origTextFarbe = Console.ForegroundColor;
            int breite = Console.WindowWidth;
            int textlen = text.Length;
            Console.Clear();
            Console.ForegroundColor = textfarbe;
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
            Console.WriteLine();
            Console.ForegroundColor = origTextFarbe;
        }
    }
}
