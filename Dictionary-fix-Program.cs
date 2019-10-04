using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yuky han 

namespace Dictionary_hw
{
    class Program
    {

        static void Main(string[] args)
        {


            // dt = new Dictionary <Tkey,TValue>
            var dt = new Dictionary<string, string>()
            {

                 {"Arrowroot" ," Canna edulis" },
                 {"Acorn Squash",  " Cucurbita pepo" },
                 {"African Daisy",  " Gerbera jamesonii" },
                 {"African Violet",  " Saintpaulia spp" },
                 {"Mesquite" , " Prosopis limensis" },
                 {"Aluminum Plant" , " Pilea cadieri" },
                 {"Alumroot" , " Heuchera sanguinea"},
                 {"Alyssum", " Alyssum spp" },
                 {"American Rubber Plant" ," Peperomia obtusifolia" },
                 {"Maple", " Acer ginnala" },
                 {"Spider Plant", " Chlorophytum comosum"},

            };



            for (int i = 0; i < dt.Count; i++)

            {
                foreach (KeyValuePair<string, string> alist in dt)

                    Console.WriteLine(alist.Key + " --> " + alist.Value);


                Console.WriteLine("------------------------");
                Console.WriteLine("Which one are you looking for??");

                string item;
                string search;

                search = Console.ReadLine();

                if (dt.TryGetValue(search, out item))
                {
                    Console.WriteLine(item);
                }

                else
                {
                    Console.WriteLine("try again");

                }
                Console.ReadKey();
                Console.Clear();


            }
        }
    }
}












