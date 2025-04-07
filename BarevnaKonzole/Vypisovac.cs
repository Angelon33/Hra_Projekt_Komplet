using System;
using BarevnaKonzole;

namespace BarevnaKonzole
{
    public class Vypisovac
    {
        //internal je přístupnost v projektu (něco jako public)
        public int Suma(int a, int b)
        {
            return a + b;

     
        }




        public void Vypis(string text)
        {

            Vypis(text, Console.ForegroundColor, Console.BackgroundColor);

        }
        public void Vypis(string text, ConsoleColor barvaText)
        {
            Vypis(text, barvaText, Console.BackgroundColor);

        }
        //vytvoření dokumentace před metodou použítím "///" 

        /// <summary>
        /// Metoda vypise barevne do konzole.
        /// </summary>
        /// <param name="text">Text ktery chci vypsat</param>
        /// <param name="barvaText">Barva pisma</param>
        /// <param name="BarvaPoz">Barva pozadi</param>
        public void Vypis(string text, ConsoleColor barvaText, ConsoleColor BarvaPoz)
        {
            Console.ForegroundColor = barvaText;
            Console.BackgroundColor = BarvaPoz;
            Console.Write(text);
            Console.ResetColor();

        }

        //přetěžování metod, uděláním různých variant


        public void VypisOdstavec()
        {
            Console.WriteLine();


        }
        public void VypisOdstavec(string text, ConsoleColor barvaText)
        {
            Vypis(text + Environment.NewLine, barvaText, Console.BackgroundColor);


        }
        public void VypisOdstavec(string text)
        {
            Vypis(text + Environment.NewLine);


        }


        public void VypisOdstavec(string text, ConsoleColor barvaText, ConsoleColor BarvaPoz)
        {
            Vypis(text + Environment.NewLine, barvaText, BarvaPoz);


        }
    }
}