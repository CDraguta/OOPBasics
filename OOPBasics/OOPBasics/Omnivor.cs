using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Omnivor : Animal
    {
        public override double Energie()
        {
            decimal sumaEnergie = 0;
            decimal numar = 0;
            decimal sumaGreutate = 0;
            decimal energieOmnivor = 0;

            foreach (Mancare stomacList in stomac)
            {
                sumaEnergie = sumaEnergie + stomacList.Energie;
                sumaGreutate = sumaGreutate + stomacList.greutate;
                numar++;
            }

            decimal medie = sumaGreutate / numar;
            energieOmnivor = 0.35m + coeficient * medie + sumaEnergie;
            return (double)energieOmnivor;

        }
    }
}
