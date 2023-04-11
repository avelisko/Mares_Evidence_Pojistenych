using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mares_Evidence_Pojistenych
{
    //Pojištěný v evidenci
    class Pojisteny
    {
        // Jméno pojištěného
        public string Jmeno { get; set; }
       
        // Příjmení pojištěného
        public string Prijmeni { get; set; }
        
        // Věk pojištěného
        public int Vek { get; set; }
        
        // Telefoní číslo pojištěného
        public int Telefon { get; set; }

        //Vytvoří novou instanci Pojistenych
        public Pojisteny(string jmeno, string prijmeni, int vek, int telefon)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.Telefon = telefon;
        }
        
        // Vrátí Jméno,Příjmení,Věk a Telefon pojištěného
        public override string ToString()
        {
            // Nastaavení maximální délky jména,příjmení,věku a tel čísla
            int maxJmenoPrijmeniLength = 35;  
            int maxVekLength = 9; 
            int maxTelefonLength = 15; 

            // Použítí Pad.Right k zarovnání výpisu pod sebe 
            string jmenoPrijmeni = $"Jméno: {Jmeno} {Prijmeni}".PadRight(maxJmenoPrijmeniLength);
            string vek = $"Věk: {Vek}".PadRight(maxVekLength);
            string telefon = $"Telefon: {Telefon}".PadRight(maxTelefonLength);

            return $"{jmenoPrijmeni} {vek}{telefon}";
        }
    }
}
