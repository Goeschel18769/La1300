using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Zahlenratespiel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool gewonnen = false;
            int Zahl=0;
            bool fang=false;
            bool nochmal=false;
            string antwortNochmal;
            bool start = true;
            string gerateneAntwort;

            Farben farben = new Farben();


            do
            {
                Start startGame = new Start();
                zahlencheck Bertram = new zahlencheck();
                

                Console.WriteLine("Hallo reisender");
                Console.WriteLine("Möchtest du ein Spiel spielen?");
                Console.WriteLine("Wenn ja schreibe a wenn nein schreibe b und falls du nicht weisst was ein Spiel ist schreibe c");
                do {
                    gerateneAntwort = Console.ReadLine();
                    startGame.start(gerateneAntwort);
                    Console.WriteLine(startGame.abcAntworter3000);

                    if (startGame.abcAntworter3000 == "Hoppla, schreibe a,b oder c um zu antworten.")
                    { start = false; }
                    else 
                    { start = true; }

                } while (start==false);


                Console.WriteLine("Drücken Sie die Eingabetaste um das Spiel zu beginnen.");
                Console.ReadLine();
                Console.Clear();


                nochmal = false;
                farben.Blau();
                Console.WriteLine("ZahlenratespielV2");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                farben.Weiss();
                Console.WriteLine("Rate eine Zahl zwischen 1 und 100");
                
                
                    
                while (gewonnen == false)
                {
                    while (fang == false)
                    {
                        try
                        {
                        

                            Zahl = Convert.ToInt32(Console.ReadLine());
                            fang = true;
                        }
                        catch
                        {
                            Console.WriteLine("Schreibe nur ganze Zahlen");
                        }
                    }

                    fang = false;
                    Bertram.Raten(Zahl);
                    Bertram.Versuche(1);
                    
                    Console.WriteLine(Bertram.checkobGewonnen);
                    farben.Weiss();
                    if (Bertram.sieg == true)
                    {
                        gewonnen = true;
                    }
                    

                }

                Console.WriteLine("Wollen Sie nochmal spielen?");
                antwortNochmal = Console.ReadLine();
                Bertram.Again(antwortNochmal);
                if (Bertram.Nochmal=="true")
                {
                    gewonnen = false;
                    nochmal = true;
                    farben.Weiss();
                    Console.Clear();
                }
                else
                {
                    farben.DunkelCyan();
                    Console.WriteLine("Adieu");
                    farben.Weiss();

                }
            } while (nochmal == true);

        }
        
        
        
    }
    
}