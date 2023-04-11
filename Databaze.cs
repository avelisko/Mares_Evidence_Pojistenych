using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mares_Evidence_Pojistenych
{
    // Třída zpracovává kolekci pojištěných
    class Databaze
    {
        // Kolekce pojištěných
        private List<Pojisteny> seznamPojistenych = new List<Pojisteny>();

        // Přidá nového pojištěného do databáze
        public void PridejPojisteneho(Pojisteny pojisteny)
        {
            seznamPojistenych.Add(pojisteny);
        }

        // Vyhledá pojištěného z databáze
        public Pojisteny VyhledejPojisteneho(string jmeno, string prijmeni)
        {
            foreach (Pojisteny pojisteny in seznamPojistenych)
            {
                if (pojisteny.Jmeno == jmeno && pojisteny.Prijmeni == prijmeni)
                {
                    return pojisteny;
                }
                    
            }
            return null;
        }

        // Vrací seznam pojištěných
        public List<Pojisteny> VratSeznamPojistenych()
        {
            return seznamPojistenych;
        }
    }
}
