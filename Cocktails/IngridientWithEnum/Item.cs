using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.IngridientWithEnum
{
    class Item : Entity
    {
        public float Volume { get; set; }
        public IngridientType TypeOfIngridient { get; set; }

        public Item()
        {
        }

        public Item(string name) : base(name)
        {

        }

        public Item(string name, float _volume, IngridientType type) : base(name)
        {
            Volume = _volume;
            TypeOfIngridient = type;
        }


    }
}
