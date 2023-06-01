using System;
using System.Data;
using System.IO.Pipes;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication
{
    // maak een persoon class
    class Persoon
    {
        //maak variabelen aan
        public string adres;
        public string naam;

        // koppel adres en naam aan persoon klasse
        public Persoon(string naam, string adr)
        {
            this.adres = adr;
            this.naam = naam;
        }

        static void Main(string[] args)
        {
            //aanmaken van de personen
            Persoon Harmen = new Persoon("Harmen Smit" ,"Ringmus 13");
            Persoon Hendrik = new Persoon("Hendrik Jansen", "Zwolseweg 45");
            Persoon pietje = new Persoon("Pietje van Amersfoort", "Regenboogstraat 33");

            //personen in een lijst
            var personen = new List<Persoon>();
            personen.Add(Harmen);
            personen.Add(Hendrik);
            personen.Add(pietje);

            //oneindige loop
            while (true)
            {
                Console.WriteLine("Voer een commando in om uit te voeren, kies uit: list, createfile, date, reverse, exit");
                string input = Console.ReadLine();

                //commando list
                if (input == "list")
                {
                    foreach (Persoon man in personen)
                    {
                        Console.WriteLine(man.naam + " // " + man.adres);
                    }
                }

                //commando createfile
                else if (input == "createfile")
                {
                    // bepaal het pad
                    Console.Write("in welke directory wilt u het bestand?(geef het pad naar het bestand) // ");
                    string path = Console.ReadLine() + "\\MyTest.txt";


                    // bepaal de text in het bestand
                    string text = "code geschreven door Harmen Smit";

                    // maak het bestand aan en schrijf er naar toe
                    string createText = text;
                    File.WriteAllText(path, createText);

                    //controleer of het bestand bestaat
                    if (!File.Exists(path))
                    {
                        Console.WriteLine("aanmaken van het bestand mislukt!");
                    }
                    else
                    {
                        Console.WriteLine("aanmaken van het bestand geslaagd!");
                    }
                }

                else if (input == "date")
                {
                    DateTime now = DateTime.Now;
                    Console.WriteLine(now.ToString("dd/MM/yyyy"));
                }

                else if (input == "reverse")
                {
                    // get text van gebruiker
                    Console.Write("welke tekst wil je verkeerdom? // ");
                    string textNonReverse = Console.ReadLine();

                    // zet de input in een char array, reverse en maak er weer een string van
                    char[] lijst = textNonReverse.ToCharArray();
                    Array.Reverse(lijst);
                    string textReverse = new string(lijst);

                    // print de omgedraaide string
                    Console.WriteLine(textReverse);

                }

                else if (input == "exit")
                {
                    break;
                }
            }
        }
    }
}