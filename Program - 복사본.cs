using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Yuky han
namespace dictionary_p
{
    class Program
    {
        static void Main(string[] args)
        {
            // Key and Values
            var dt = new Dictionary<string,string>()
            {

                     {"1","Ichi"},
                     {"2","Ni"},
                     {"3","Sahng"},
                     {"4","Si"},
                     {"5","gou"}


            };
            Console.WriteLine("Here are " + dt.Count + " sound of numbers in Japanese");
           
            foreach (KeyValuePair<string,string> ditem in dt)
            {
                Console.WriteLine(ditem);
            }


            Console.WriteLine("\n♣New Update♣");
            dt["6"] = "Lokku";
            dt.Add("7", "Nana");
           
            foreach (KeyValuePair<string, string> ditem in dt)  
            {
                Console.WriteLine(ditem);
            }

            Console.WriteLine("\n♣New Edit♣");
            dt["5"] = "Go";

            foreach (KeyValuePair<string, string> ditem in dt)
            {
                Console.WriteLine(ditem);
            }

            Console.WriteLine("\n♣See only Japanese Pronunciation♣");
            foreach (string ditem in dt.Values)
            {
                Console.WriteLine(ditem);
            }


            Console.ReadKey();

        }
    }

       
    }
   
