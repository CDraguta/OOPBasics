using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Erbivor : Animal 
    {
        public override double Energie()
        {

            decimal sumaEnergie = 0;
            decimal numar = 0;
            decimal sumaGreutate = 0;
            decimal energieErbivor = 0;

            foreach (Mancare stomacList in stomac)
            {
                sumaEnergie = sumaEnergie + stomacList.Energie;
                sumaGreutate = sumaGreutate + stomacList.greutate;
                numar++;
            }

            decimal medie = sumaGreutate / numar;
            energieErbivor = 0.5m + 1/3 * medie + sumaEnergie;
            return (double)energieErbivor;
        }
    }
}
