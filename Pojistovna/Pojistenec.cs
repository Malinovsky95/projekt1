using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna
{
    public class Pojistenec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public int Telefon { get; set; }

        


        
        public Pojistenec(string jmeno, string prijmeni, int vek, int telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        public void VypisPojistence()
        {
            Console.Write("{0} ", Jmeno);
            Console.Write("{0} ", Prijmeni);
            Console.Write("{0}    ", Vek);
            Console.Write("{0}    \n", Telefon);
        
        }
    }
}
