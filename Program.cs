using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mares_Evidence_Pojistenych
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance evidence
            Evidence evidence = new Evidence();
            char volba = '0';
            
            // hlavní cyklus
            while (volba != '4')
            {
                evidence.VypisUvodniObrazovku();
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojistěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        evidence.PridejPojisteneho();
                        break;
                    case '2':
                        evidence.VypisSeznamPojistenych();
                        break;
                    case '3':
                        evidence.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine("Ukončuji aplikaci Evidence pojištěných, libovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
