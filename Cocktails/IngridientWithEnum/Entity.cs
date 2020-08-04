using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.IngridientWithEnum
{
    class Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Entity()
        {

        }

        public Entity(string name)
        {
            Name = name;
        }
    }
}
