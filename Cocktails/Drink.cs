using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Drink : Entity
    {
        public List<Ingridient> Ingridients { get; set; }

        public Drink(string _name) : base(_name)
        {
            
        }

        public Drink()
        {

        }
        

        public void AddIngridient(params Ingridient[] _ingridients)
        {
            for (int i = 0; i < _ingridients.Length; i++)
            {
                Ingridients.Add(_ingridients[i]);
            }
        }
    }
}
