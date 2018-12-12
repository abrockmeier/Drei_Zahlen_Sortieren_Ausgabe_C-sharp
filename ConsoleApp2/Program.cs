using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int zahl1;
            int zahl2;
            int zahl3;
            int zwischen;
            //string eingabe;
            
            //Eingabe
            Console.WriteLine("Bitte geben sie eine Zahl ein:");
            
            /*
            eingabe = Console.ReadLine();

            if ( int.TryParse(eingabe, out zahl1))
            {
                //Verarbeitung (hier das Einlesen und die Konvertierung...)
            }
            else
            {
                //Abfangen der Fehler und erneute Benutzereingabe...
            }
            */

            zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben sie eine weiter Zahl ein:");

            zahl2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Bitte geben sie noch eine weiter Zahl ein:");

            zahl3 = Convert.ToInt32(Console.ReadLine());
            

            //Verarbeitung
            if (zahl3 > zahl2)
                {
                zwischen = zahl2;

                zahl2 = zahl3;

                zahl2 = zwischen;
                }

            if (zahl3 > zahl1)
                {

                zwischen = zahl1;

                zahl1 = zahl3;

                zahl3 = zwischen;

                }
            if (zahl3 > zahl2)
                {
                zwischen = zahl2;

                zahl2 = zahl3;

                zahl3 = zwischen;

                }
            
            


            //Ausggabe
            Console.WriteLine("Die Reihenfolge (absteigend) lautet {0}, {1}, {2}",
                zahl1, zahl2, zahl3);
            Console.ReadKey();
            Console.WriteLine("Berechnung abgeschlossen!");
        }
    }
}
