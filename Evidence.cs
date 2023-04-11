using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mares_Evidence_Pojistenych
{
    // Třída reprezentující evidenci pojištěných
    class Evidence
    {
        // Databáze s pojištěnými
        private Databaze databaze;

        // Vytvoření nové instance evidence
        public Evidence()
        {
            databaze = new Databaze();
        }

        // K výpisu úvodní obrazovky
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("=====================");
        }

        // Vyzve uživatele k zadání jména,příjmění,věku a tel. čísla + uloží do databáze
        public void PridejPojisteneho()
        {
            Console.WriteLine("Přidání nového pojištěného");
            Console.WriteLine("==========================");
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Zadejte telefoni cislo: ");
            int telefon = int.Parse(Console.ReadLine());
            Console.Write("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Pojisteny pojisteny = new Pojisteny(jmeno, prijmeni, vek, telefon);
            databaze.PridejPojisteneho(pojisteny);
            Console.WriteLine();//odřádkování
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
        }

        // Vyzve uživatele k zadání jména,příjmění hledaného pojištěného a vyhledá v databázi
        public void VyhledejPojisteneho()
        {
            Console.WriteLine("Vyhledání pojištěného");
            Console.WriteLine("======================");
            Console.Write("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadejte příjmení pojištěného: ");
            string prijmeni = Console.ReadLine();
            Pojisteny pojisteny = databaze.VyhledejPojisteneho(jmeno, prijmeni);
            if (pojisteny != null)
            {
                Console.WriteLine("Nalezený pojištěný:");
                Console.WriteLine(pojisteny);
            }
            else
            {
                Console.WriteLine("Pojištěný nebyl nalezen.");
            }
            Console.WriteLine();//odřádkování
            Console.WriteLine("Pokračujte libovolnou klávesou...");

        }

        // K výpisu všech pojištěných uložených v databázi
        public void VypisSeznamPojistenych()
        {
            Console.WriteLine("Výpis všech pojištěných");
            Console.WriteLine("========================");
            List<Pojisteny> seznamProVypis = databaze.VratSeznamPojistenych();
            if (seznamProVypis.Count == 0)
            {
                Console.WriteLine("V databázi nejsou žádní pojištění.");
            }
            else
            {
                foreach (Pojisteny pojisteny in seznamProVypis)
                {
                    Console.WriteLine(pojisteny);
                }
            }
            Console.WriteLine();//odřádkování
            Console.WriteLine("Pokračujte libovolnou klávesou...");

        }
    }
}
