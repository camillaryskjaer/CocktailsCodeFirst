using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.IngridientWithEnum
{
    class Drink : Entity
    {
        public List<Item> Items { get; set; }
        public Drink()
        {
        }

        public Drink(string name) : base(name)
        {

        }
    }
}
