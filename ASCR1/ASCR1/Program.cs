using System;
using Microsoft.VisualBasic.FileIO;

namespace ASCR1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!!");
            Console.WriteLine("Introduceti numarul de pantof");
            string line;
            line = Console.ReadLine();

            int numarPantof;

            try
            {
                numarPantof = int.Parse(line);
                //int.TryParse(line, out numarPantof);
                Console.WriteLine($"Aveti {numarPantof} numarul la pantof");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}
