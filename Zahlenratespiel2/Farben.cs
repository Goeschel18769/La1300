using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenratespiel2
{
    public class Farben
    {
        //Diese Klasse sorgt dafür, dass das Farbenändern der Schrift einfacher ist.
        public void Weiss()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Gelb()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void DunkelGelb()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public void Rot()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void DunkelRot()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public void Blau()
        { Console.ForegroundColor = ConsoleColor.Blue; }
        public void Cyan() {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public void DunkelCyan() {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public void Gruen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void DunkelMagenta()
        { Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}
