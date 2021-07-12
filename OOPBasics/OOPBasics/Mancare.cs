using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class Mancare
    {
        public decimal greutate { get; set; }
        private decimal energie; 
        public decimal Energie
        {
            get
            { if (energie > 0 && energie <= 0.5m)
                {
                    return energie;
                }else
                {
                    return 0 ; 
                }

            }
            set
            {
                if (energie >= 0 && energie <= 0.5m)
                {
                   this.energie = energie;
                }
                else
                {
                    energie = 0;
                }

            }
        }

    }
}
