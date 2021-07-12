using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Carnivor : Animal 
    {
        public override double Energie()
        {
            decimal sumaEnergie = 0;
            decimal numar = 0;
            decimal sumaGreutate = 0;
            decimal energieCarnivor = 0;

            foreach(Mancare stomacList in stomac )
            {
                sumaEnergie = sumaEnergie + stomacList.Energie;
                sumaGreutate = sumaGreutate + stomacList.greutate;
                numar++;
            }

            decimal medie = sumaGreutate / numar;
            energieCarnivor = 0.2m - 1/5 * medie + sumaEnergie;
            return (double)energieCarnivor;
        }

    }
}
