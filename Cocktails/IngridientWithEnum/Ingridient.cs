using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.IngridientWithEnum
{
    enum IngridientType
    {
        Solid,
        Fluid
    }
    class Ingridient : Entity
    {
        IngridientType typeIngridient { get; set; }

        public Ingridient()
        {

        }

        public Ingridient(string name) : base(name)
        {
        }
    }
}
