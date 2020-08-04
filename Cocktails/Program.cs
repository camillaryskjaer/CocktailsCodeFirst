using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill2" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            */

            /*
            //ID:1	Name:Merry	Millimeters:NULL	Amount:1	Discriminator:Solid	 DrinkID:1
            //ID:2	Name:Blood	Millimeters:100	    Amount:100	Discriminator:Fluid	 DrinkID:1
            using (var ctx = new CockTailContext())
            {
                Drink drink = new Drink("Bloody Mery")
                {
                    Ingridients = new List<Ingridient>()
                    {
                        new Solid("Merry", 1),
                        new Fluid("Blood", 100f)
                    }
                };

                ctx.Drinks.Add(drink);
                ctx.SaveChanges();
            }
            */


            /*
            // ID:1	Volume:90	TypeOfIngridient:1	Name:Blood	DrinkID:1
            using (var ctx = new IngridientWithEnum.CockTailContext())
            {
                IngridientWithEnum.Drink drink = new IngridientWithEnum.Drink("Bloody Mery")
                {
                    Items = new List<IngridientWithEnum.Item>()
                    {
                        new IngridientWithEnum.Item("Blood", 90f, IngridientWithEnum.IngridientType.Fluid),
                        new IngridientWithEnum.Item("Merry", 1, IngridientWithEnum.IngridientType.Solid)
                    }
                };

                ctx.Drinks.Add(drink);
                ctx.SaveChanges();
            }
            */

            using (var ctx = new IngridientWithEnum.CockTailContext())
            {
                var result = ctx.Drinks.Select(x => x.Name);

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }
}
