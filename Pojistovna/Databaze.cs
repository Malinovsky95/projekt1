using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Pojistovna
{
    public class Databaze
    {
        private List<Pojistenec> pojistenci;
        

        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }
       
        public void PridatPojistence()
        {
            Console.WriteLine("Zadani noveho pojištěnce");
            Console.WriteLine("Jméno");
            string Jmeno = Console.ReadLine();
            Console.WriteLine("Přijmení");
            string Prijmeni = Console.ReadLine();
            Console.WriteLine("Věk");
            int  Vek= int.Parse(Console.ReadLine());
            Console.WriteLine("Telefon");
            int Telefon = int.Parse(Console.ReadLine());

            Console.WriteLine("Data byla uložena, pokračuj stisknutím libovolné klávesy...");

            Pojistenec pojistenec = new Pojistenec(Jmeno,Prijmeni,Vek,Telefon);
            pojistenci.Add(pojistenec);
        }
        public void VypisPojistencu()
        {
            Console.WriteLine("Výpis pojištěnců");
            foreach(Pojistenec pojistenec in pojistenci) 
            {
                pojistenec.VypisPojistence();
            }
            Console.WriteLine("Pokračuj stiknutím libovolné klávesy....");
        }
        //Vymazání pojištěného
        public void SmazatPojistence()
        {
            Console.WriteLine("Smazat pojištěnce");
            for (int i = 0; i < pojistenci.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, pojistenci[i].Prijmeni);
            }
            Console.WriteLine("Pořadové číslo pro smazání: ");
            int indexSmazat = int.Parse(Console.ReadLine())-1;
            if (indexSmazat >= 0 && indexSmazat < pojistenci.Count)
            {
                Console.WriteLine("Pojištěnec: {0} smazán", pojistenci[indexSmazat].Prijmeni);
                pojistenci.RemoveAt(indexSmazat);
            }
            else
            {
                Console.WriteLine("Špatné číslo. Pojištěnec nebyl smazán");
            
            }
        }
        //Vyhledání pojištěného podle jména a příjmení
        public void NajitPojistence()

        {
            Console.WriteLine("Zadej jméno: ");
            string vysledek1 = Console.ReadLine();
            Console.WriteLine("Zadej příjmení: ");
            string vysledek2 = Console.ReadLine();


            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.Prijmeni == vysledek2 && pojistenec.Jmeno == vysledek1)
                {
                    pojistenec.VypisPojistence();
                }
                else 
                {

                    Console.WriteLine("Uživatel nenalezen");
                        
                }
             
            }

        }

        
        
        
    }
}
