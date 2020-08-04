using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Solid : Ingridient
    {
        public float Amount { get; set; }

        public Solid(string _name) : base(_name)
        {

        }

        public Solid(string _name, float _amount) : this(_name)
        {
            Amount = _amount;
        }
    }
}
