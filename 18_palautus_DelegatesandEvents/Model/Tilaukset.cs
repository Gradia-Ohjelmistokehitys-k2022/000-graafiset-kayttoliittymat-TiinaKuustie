using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _18_palautus_DelegatesandEvents.Model
{
    public class Tilaukset
    {
        public int rolling;
        public int Tilausnumero { get; set; }
        public Tuotteet Tuote { get; set; }
        public string Asiakas {  get; set; }    
        public string Hyllypaikka { get; set; }
        public DateTime LastPickup { get; set; }

        public static List<Tilaukset> tilauslista { get; set; }  

        public Tilaukset() { }

        public void initialize()
        {
            tilauslista = new List<Tilaukset>();
        }

        public Tilaukset(int numero,Tuotteet tuote, DateTime lastdate, string asiakas,string hyllypaikka)
        {
            Tilausnumero = numero;
            Tuote = tuote;
            LastPickup = lastdate;
            Asiakas = asiakas;
            Hyllypaikka = hyllypaikka;
               
        
        }

        public void UusiHyllytys(Tuotteet tuote, DateTime lastdate, string asiakas,string hyllypaikka)
        {
            rolling++;
            int numero = rolling;

            Tilaukset tilaus = new Tilaukset(numero, tuote, lastdate,asiakas,hyllypaikka);
            tilauslista.Add(tilaus);
        }
    }
}
