using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hra_model;
using Newtonsoft.Json;

namespace Hra_Projekt.test
{
    public class Program
    {
        static Vypisovac vypisovac;
        static Hra hra;
        static void Main(string[] args)
        {

            vypisovac = new Vypisovac();
            //předpřipravit si knihovnu s knihovnama
            hra = new Hra();    

            
            

            bool hraBezi = true;


            vypisovac.VypisOdstavec("Vitej ve hře", ConsoleColor.Black, ConsoleColor.Red);
            Console.WriteLine();
            Console.WriteLine();
            vypisovac.Vypis("Jméno tvé postavy je: ");
            vypisovac.VypisOdstavec("Pepík", ConsoleColor.Red);        
            vypisovac.VypisOdstavec("Stiskni libovolné tlačítko pro pokračování");
            Console.ReadKey();
        
            
           using (StreamWriter file = File.CreateText(Directory.GetCurrentDirectory() + "\\mistnosti.txt"))
                {
                    JsonSerializer serializer = new JsonSerializer();

                    serializer.Formatting = Formatting.Indented;
                    serializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
                    serializer.ObjectCreationHandling = ObjectCreationHandling.Replace;
                    serializer.Serialize(file, hra.ListMistnosti);


                }
              
         
          
            /*
            string filecontent = File.ReadAllText(Directory.GetCurrentDirectory() + "\\mistnosti.txt");
            JsonSerializer deserializer = new JsonSerializer();
            deserializer.Formatting = Formatting.Indented;
            deserializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            var x = deserializer.Deserialize<List<Mistnost>>(new JsonTextReader(new StringReader(filecontent)));
            
            */
            
            //hra.AktualniMistnost = x[0];


            while (hraBezi)
            {
                

                

                Console.Clear();
                vypisovac.Vypis("Tvá postava se nachází ve: ", ConsoleColor.White, ConsoleColor.Black);
                PopisSe(hra.aktualniMistnost);
                vypisovac.VypisOdstavec();
                vypisovac.VypisOdstavec("Máš před sebou rozhodnutí: ");
                vypisovac.VypisOdstavec(" Napiš: ");
                vypisovac.Vypis("jít", ConsoleColor.Red);
                vypisovac.VypisOdstavec(" pro pohyb mezi lokacemi.");
                vypisovac.Vypis("prozkoumat", ConsoleColor.Red);
                vypisovac.VypisOdstavec(" pro prozkoumaní lokace");
                vypisovac.Vypis("vzít", ConsoleColor.Red);
                vypisovac.VypisOdstavec(" pro sběr předmetů");
                vypisovac.Vypis("inventář", ConsoleColor.Red);
                vypisovac.VypisOdstavec(" pro vypsání obsahu inventáře");
                const string jit = "jít";
                const string prozkoumat = "prozkoumat";
                const string vzit = "vzít";
                const string inventar = "inventar";
                string volbaCinnost = Console.ReadLine();
                switch (volbaCinnost)
                {
                    case jit:
                        
                        vypisovac.VypisOdstavec("Zvol si kam se vydáš");
                        VypisOkolni(hra.aktualniMistnost);
                        vypisovac.VypisOdstavec("Zadej q pro ukončení hry");
                        string volba = Console.ReadLine();
                        if (volba == "q")
                        {
                            hraBezi = false;
                        }
                        else
                        {
                            try
                            {

                                int volbaMisto = int.Parse(volba);
                                hra.aktualniMistnost = hra.aktualniMistnost.Okolni[volbaMisto - 1];

                            }
                            catch
                            {
                                vypisovac.VypisOdstavec("Chybná volba, zvol z nabídky", ConsoleColor.Red, ConsoleColor.White);
                                vypisovac.VypisOdstavec("Stiskni libovolné tlačítko pro návrat do nabídky", ConsoleColor.Red, ConsoleColor.White);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case prozkoumat:

                        VypisPredmety(hra.aktualniMistnost);
                        vypisovac.VypisOdstavec();
                        VypisNPC(hra.aktualniMistnost);
                        Console.ReadLine();

                        break;

                    case vzit:
                        vypisovac.VypisOdstavec("Můžeš vzít předmět: ");
                        VypisPredmety(hra.aktualniMistnost);
                        vypisovac.VypisOdstavec();
                        string volbaP = Console.ReadLine();
                        try
                        {

                            int volbaPredmet = int.Parse(volbaP);
                            SebratPredmet(volbaPredmet, hra.postava, hra.aktualniMistnost);

                        }
                        catch
                        {
                            vypisovac.VypisOdstavec("Chybná volba, zvol z nabídky", ConsoleColor.Red, ConsoleColor.White);
                            vypisovac.VypisOdstavec("Stiskni libovolné tlačítko pro návrat do nabídky", ConsoleColor.Red, ConsoleColor.White);
                            Console.ReadKey();
                        }
                        
                        Console.ReadLine();

                        break;
                    case inventar:
                        vypisovac.VypisOdstavec("Toto je tvůj inventář: ");
                        VypisInventar(hra.postava);
                        vypisovac.VypisOdstavec();
                        Console.ReadLine();

                        break;

                }

                           




                }




                
           









            //mistnost.jit(Lokace.kovarna);



            Console.ReadKey();
        }

        private static void VypisPredmety(Mistnost aktualniMistnost)
        {

            vypisovac.VypisOdstavec("Vidíš před sebou tyto věci: ");
            int i = 0;
            foreach (Predmet p in aktualniMistnost.PredmetMistnost) //iteruje přes ten list
            {
                vypisovac.VypisOdstavec($"{i + 1}: {p.NazevPredmetu}", ConsoleColor.Red);
                i++;

            }
        }
        public static void VypisOkolni(Mistnost aktualniMistnost)
        {
            int i = 0;
            foreach (Mistnost m in aktualniMistnost.Okolni) //iteruje přes ten list
            {
                vypisovac.VypisOdstavec($"{i + 1}: {m.Jmeno}", ConsoleColor.Red);
                i++;

            }


        }
        public static void PopisSe(Mistnost aktualniMistnost)
        {

            vypisovac.Vypis($" {aktualniMistnost.Jmeno}, Popis: {aktualniMistnost.Popis}", ConsoleColor.Blue);

        }
        public static void VypisNPC(Mistnost aktualniMistnost)
        {
            vypisovac.VypisOdstavec("Vidíš před sebou tyto postavy: ");
            int i = 0;
            foreach (NPC n in aktualniMistnost.NpcMistnost) //iteruje přes ten list
            {
                vypisovac.VypisOdstavec($"{i + 1}: {n.JmenoNPC}", ConsoleColor.Red);
                i++;

            }


        }
        public static void SebratPredmet(int volbaPredmet, Postava postava, Mistnost aktualniMistnost)
        {
            postava.PredmetPostavy.Add(aktualniMistnost.PredmetMistnost[volbaPredmet - 1]);
            aktualniMistnost.PredmetMistnost.Remove(aktualniMistnost.PredmetMistnost[volbaPredmet - 1]);




        }
        public static void VypisInventar(Postava postava)
        {
            vypisovac.VypisOdstavec("V inventáři máš tyto věci: ");
            int i = 0;
            foreach (Predmet p in postava.PredmetPostavy) //iteruje přes ten list
            {
                vypisovac.VypisOdstavec($"{i + 1}: {p.NazevPredmetu}", ConsoleColor.White, ConsoleColor.DarkRed);
                i++;

            }


        }
        public void PredmetPopis(Predmet predmety)
        {

            vypisovac.Vypis($" {predmety.NazevPredmetu}, Popis: {predmety.PopisPredmetu}", ConsoleColor.Blue);

        }
    }
}
