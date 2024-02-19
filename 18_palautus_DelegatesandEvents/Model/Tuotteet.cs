using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_palautus_DelegatesandEvents.Model
{
    public class Tuotteet
    {
        public int viivakoodi = 0;
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Paino { get; set; }
        public decimal Price { get; set; }

    

        public Tuotteet() { }

        public Tuotteet(string viiva, string name, decimal paino, decimal price) 
        {
            Id = viiva;
            Name = name;
            Paino = paino;
            Price = price;

        
        }
   

        
        public Tuotteet GenerateProducts(string nimi)
        {
        

            string v = "551264" + viivakoodi.ToString();
          

            Random random = new Random();
            decimal painox = random.Next(1, 10);
            Random random3 = new Random();
            decimal pricex = random3.Next(20, 120);


            Tuotteet t1 = new Tuotteet(v,nimi, painox,pricex);
        

            Random random4 = new Random();
           int z = random4.Next(10,100);
            viivakoodi += z;
            return t1;
        }
    }
}
