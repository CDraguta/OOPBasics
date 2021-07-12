using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class Animal 
    {
        public string nume { get; set; }
        protected decimal greutate { get; set; }
        public struct dimensiune
        {
             decimal lungime { get; set; }
             decimal latime { get; set; }
             decimal inaltime { get; set; }

            public dimensiune(decimal lungime, decimal latime, decimal inaltime)
            {
                this.lungime = lungime;
                this.latime = latime;
                this.inaltime = inaltime;
            }


        }
        protected decimal viteza { get; set; }
        internal List<Mancare> stomac = new List<Mancare>();
        public static int numar = 0;

        public Animal() { }
        protected Animal(string nume, decimal greutate,dimensiune dim, decimal viteza)
        {
            this.nume = nume;
            this.greutate = greutate;
            this.viteza = viteza;
            //struct : ??
            

            numar++;
        }

        public decimal coeficient;
        public static int[] numarAnimaleMancare = new int[3];
        //i=0 este pentru animale care au mancat
        //i=1 este pentru animale care au mancat plante
        //i=2 este pentru animale care au mancat carne
        public void Mananca(Mancare m)
        {        
            if (m is Planta)
            {
                coeficient = 0.5m;          
            }
            else
            {
                coeficient = -0.5m;
            }

            if ((this.GetType() is Carnivor && m is Carne ) || (this.GetType() is Erbivor && m is Planta) || (this.GetType() is Omnivor &&  (m is Carne || m is Planta)) ){
                decimal greutateMancare = m.greutate;
               
                if (decimal.Compare(greutateMancare, 0.125m * greutate) < 0)
                {
                    stomac.Add(m);
                    numarAnimaleMancare[0]++;
                    Console.WriteLine("mananca");

 
                    if (m is Planta && this.GetType() is Erbivor)
                    {
                        numarAnimaleMancare[1]++;
                    }
                    else if (m is Carne && this.GetType() is Carnivor)
                    {
                        numarAnimaleMancare[2]++;
                    }
                }



            }

        }

        public abstract double Energie();

        public void Alearga (decimal distanta)
        {
            double energie = this.Energie();
            decimal timp = distanta / (viteza / (decimal) energie); 
            Console.WriteLine("Animalul parcurge distanta " + distanta + " in timpul " + timp);
        }
    }
}
