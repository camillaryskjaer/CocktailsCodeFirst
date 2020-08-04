using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    abstract class Entity
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Entity(string _name)
        {
            this.Name = _name;
        }
        public Entity()
        {

        }
    }
}
