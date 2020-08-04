using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Fluid : Ingridient
    {
        public float Milliliters { get; set; }

        public Fluid(string _name) : base(_name)
        {

        }

        public Fluid(string _name, float _ml) : this(_name)
        {
            Milliliters = _ml;
        }

        public Fluid()
        {

        }
    }
}
