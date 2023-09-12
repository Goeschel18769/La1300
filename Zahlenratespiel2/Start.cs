using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenratespiel2
{
    internal class Start
    {
        string antwort;

        


        public string abcAntworter3000
        {
            get
            {
                if (antwort == "a")
                {
                    return "Dann viel Spass ;)";
                }
                else if (antwort == "b")
                {

                    Environment.Exit(0);
                    return "";
                }
                else if (antwort == "c")
                {
                    return "Ein spiel ist ein spiel welches man spielt indem man es spielt um es zu spielen muss man es spielen indem man es spielt, dies wird vollbracht indem man das spiel spielt.";
                }
                else
                {
                    return "Hoppla, schreibe a,b oder c um zu antworten.";
                }

            }
        }



        public void start(string answer)
        { antwort = answer; }
    }
}
