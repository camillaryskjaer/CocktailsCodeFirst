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

            //OneWayToAddAndRead();
            //SecondWayToAddAndRead();
                                 

            Console.WriteLine("Done");
            Console.ReadKey();

        }

        /// <summary>
        /// Uses 2 classes solid and fluid
        /// </summary>
        public static void OneWayToAddAndRead()
        { 
            /// How it looks like in database
            //ID:1	Name:Merry	Millimeters:NULL	Amount:1	Discriminator:Solid	 DrinkID:1
            //ID:2	Name:Blood	Millimeters:100	    Amount:100	Discriminator:Fluid	 DrinkID:1
            using (var ctx = new CockTailContext())
            {
                //Drink drink = new Drink("Bloody Mery")
                //{
                //    Ingridients = new List<Ingridient>()
                //    {
                //        new Solid("Merry", 1),
                //        new Fluid("Blood", 100f)
                //    }
                //};

                //ctx.Drinks.Add(drink);
                //ctx.SaveChanges();

                /// Create temp list of drinks 
                List<Drink> items = new List<Drink>();
                /// Get list of drinks from database
                var resultsMain = ctx.Drinks.Include("Ingridients");

                /// Loop through list of drinks from database and add them to our temp list
                foreach (var item in resultsMain)
                {
                    items.Add(item);
                }

                // Loop though our list and get ingridients list of that object from database 
                //for (int i = 0; i < items.Count; i++)
                //{
                //    // Load() gets collection of that object from database
                //    ctx.Entry(items[i]).Collection(x => x.Ingridients).Load();
                //}
            }
        }
        
        /// <summary>
        /// Uses Enum to save if its fluid or if its solid
        /// </summary>
        public static void SecondWayToAddAndRead()
        {
            /*
            // ID:1	Volume:90	TypeOfIngridient:1	Name:Blood	DrinkID:1
            // ID:2	Volume:1	TypeOfIngridient:0	Name:Merry	DrinkID:1
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
            /*
            using (IngridientWithEnum.CockTailContext ctx = new IngridientWithEnum.CockTailContext())
            {
                var resultsMain = ctx.Drinks;
                List<IngridientWithEnum.Drink> items = new List<IngridientWithEnum.Drink>();

                foreach (var item in resultsMain)
                {
                    items.Add(item);
                }

                var results = items.Where(x => x.Items != null)
                .SelectMany(x => x.Items, (pln, tr) => new { pln, tr })
                .Where(x => x.tr.Name.Contains("Blood"))
                .OrderBy(x => x.pln.Name);

                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }
            */
        }
    }
}
