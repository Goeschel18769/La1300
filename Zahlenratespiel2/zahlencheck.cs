using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Zahlenratespiel2
{
    internal class zahlencheck
    {

        //Variabeln
        int rechenZahl;
        int geheimzahl = new Random().Next(1, 101);
        bool gewonnen = false;
        int versuche = 0;
        string antwort;

        Farben farben = new Farben();

        //Es wird überprüft ob der Spieler gewonnen hat
        public bool sieg
        {
            get
            {
                if (gewonnen == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }

        //Die geratene Zahl wird mit der Geheimzahl abgeglichen und die Antwort wird zurückgegeben.
        public string checkobGewonnen
        {
            get
            {


                if (rechenZahl == geheimzahl)
                {
                    
                    rechenZahl = 0;
                    gewonnen = true;
                    farben.Gruen();
                    return "Sie haben mit " + versuche + " Versuchen gewonnen";


                }
                else if (rechenZahl > 100 || rechenZahl < 1)
                {
                    rechenZahl = 0;
                    versuche--;
                    farben.Cyan();
                    return ("Rate nur Zahlen zwischen 1 und 100");
                }

                else if (rechenZahl - geheimzahl > 0)
                {
                    if (rechenZahl - geheimzahl <= 10)
                    {
                        rechenZahl = 0;
                        farben.Gelb();
                        return "Knapp daneben, die Zahl ist etwas zu gross";

                    }
                    else if (rechenZahl - geheimzahl <= 20)
                    {
                        rechenZahl = 0;
                        farben.DunkelGelb();
                        return "Richtige Richtung, aber noch etwas zu gross";
                    }
                    else if (rechenZahl - geheimzahl <= 60)
                    {
                        rechenZahl = 0;
                        farben.Rot();
                        return "Die Zahl ist zu gross";
                    }
                    else if (rechenZahl - geheimzahl <= 80)
                    {
                        rechenZahl = 0;
                        farben.DunkelRot();
                        return "Sie sind meilenweit vom Ziel entfernt, die Zahl ist viel zu gross";
                    }
                    else
                    {
                        rechenZahl = 0;
                        farben.DunkelMagenta();
                        return "Es ist erstaunlich wie man eine Zahl um so viel verfehlen kann, die Zahl ist viel zu gross";
                    }




                }
                else
                {
                    if (rechenZahl - geheimzahl >= -10)
                    {
                        rechenZahl = 0;
                        farben.Gelb();
                        return "Knapp daneben, die Zahl ist etwas zu klein";
                    }
                    else if (rechenZahl - geheimzahl >= -20)
                    {
                        rechenZahl = 0;
                        farben.DunkelGelb() ;
                        return "Richtige Richtung, aber etwas zu klein";
                    }
                    else if (rechenZahl - geheimzahl >= -60)
                    {
                        rechenZahl = 0;
                        farben.Rot();
                        return "Die Zahl ist zu klein";
                    }
                    else if (rechenZahl - geheimzahl >= -80)
                    {
                        rechenZahl = 0;
                        farben.DunkelRot();
                        return "Sie sind meilenweit vom Ziel entfernt, die Zahl ist viel zu klein";
                    }
                    else
                    {
                        rechenZahl = 0;
                        farben.DunkelMagenta() ;
                        return "Es ist erstaunlich wie man eine Zahl um so viel verfehlen kann, die Zahl ist viel zu klein";

                    }
                }

            }
        }


        //Es wird überprüft ob die Antwort des Spielers auf ein neuse Spiel raus will.
        public string Nochmal
        {
            get
            {
                if(antwort=="ja"||antwort=="Ja")
                { return "true"; }
                else
                {
                    return "false";
                }
            }
        }

        //Die geratene Zahl wird mit einer privaten Variable dieser Klasse abgeglichen.
        public void Raten(int gerateneZahl)
        {
            rechenZahl += gerateneZahl;


        }

        //Pro geratene Zahl geht der Versuchscounter 1 nach oben.
        public void Versuche(int rateVersuche)
        {
            versuche++;
        }

        //Die Antwort ob der Spieler nochmal Spielen will wird in einer privaten Variable gespeichert.
        public void Again(string Antwort)
        {
            antwort= Antwort;
        }
        
            

        
    }
            
    

    

    
}

