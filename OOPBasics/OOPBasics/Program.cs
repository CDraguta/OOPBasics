using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {  //2a,b
            Carnivor lup = new Carnivor();
            Erbivor oaie = new Erbivor();
            Omnivor urs = new Omnivor();
            Planta salata = new Planta();
            Carne sunca = new Carne();

            //2c

            lup.Mananca(sunca);
            lup.Mananca(sunca);

            oaie.Mananca(salata);
            oaie.Mananca(salata);
            oaie.Mananca(salata);

            urs.Mananca(sunca);
            urs.Mananca(salata);
            urs.Mananca(salata);
            urs.Mananca(salata);


            //2d
            lup.Alearga(200);
            oaie.Alearga(200);
            urs.Alearga(200);

            //2e
            Console.WriteLine("Numarul de animale instantiate este " + Animal.numar); 

            //2i.i
            List<Animal> listaAnimale = new List<Animal>();

             Animal.dimensiune d;
            //2i.ii
            for(int i = 0; i < 10; i++)
            {   //2i.iii
                Random rand = new Random();
                Type tip = typeof(TipAnimal);
                Array valori = tip.GetEnumValues();
                int index = rand.Next(valori.Length);
                TipAnimal valoare = (TipAnimal)valori.GetValue(index);

                decimal L =(decimal) rand.NextDouble();
                decimal l = (decimal)rand.NextDouble();
                decimal h = (decimal)rand.NextDouble();

                d = new Animal.dimensiune(L, l, h);

                Animal animalRandom = CreeazaAnimal(valoare, "Animal", (decimal)rand.NextDouble(), d, (decimal)rand.NextDouble());
                
                listaAnimale.Add(animalRandom);

                foreach(Animal lista in listaAnimale)
                {
                    if (lista.GetType().GetGenericArguments() is Carnivor || lista.GetType().GetGenericArguments() is Omnivor)
                    {
                        lista.Mananca(sunca);
                    }
                    else if (lista.GetType() is Erbivor)
                    {
                        lista.Mananca(salata);
                    }

                }


            }
            //2.j
            Console.WriteLine(Animal.numarAnimaleMancare[0] + "animale mananca mancare");
            Console.WriteLine(Animal.numarAnimaleMancare[2] + "animale mananca carne");
            Console.WriteLine(Animal.numarAnimaleMancare[1] + "animale mananca plante");

           
        }

        //2g
        public override string ToString()
        {
            return "Tip animal: " + this.GetType().Name + " /n Nume: " + this.GetType().GetField("nume") +
                   "/n Greutate: " + this.GetType().GetField("greutate") + "kg" +
                   "/n Dimensiuni: " + this.GetType().GetField("dimensiune.lungime") + " x " + this.GetType().GetField("dimensiune.latime") + " x " +
                   this.GetType().GetField("dimensiune.inaltime") + 
                   "/n Viteza: " + this.GetType().GetField("viteza") + "m/s .";
        }
        //2h
        public enum TipAnimal { Lup, Urs, Oaie, Veverita, Pisica, Vaca };
        public static Animal CreeazaAnimal(TipAnimal tipAnimal, string nume , decimal greutate , Animal.dimensiune dim, decimal viteza )
        {
            if (tipAnimal is TipAnimal.Lup || tipAnimal is TipAnimal.Pisica)
            {
                Carnivor animal = new Carnivor() ;
                return animal;
                
            }else if (tipAnimal is TipAnimal.Urs || tipAnimal is TipAnimal.Veverita)
            {
                Omnivor animal = new Omnivor();
                return animal;
            }else if ( tipAnimal is TipAnimal.Oaie || tipAnimal is TipAnimal.Vaca)
            {
                Erbivor animal = new Erbivor();
                return animal;
            }

            return null;

        }

    }
}
