using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binding

{
    public class Item
    {

        public string description { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public FoodType type{ get; set; }
        

        public Item()
        {

        }
       


        public void About()
        {


            //Console.WriteLine("{0} : {1}, {2}", name, price, description);



        }



    }


    public class Food : Item
    {
        int amountounces;
        internal Array ingredients;
        

        public Food(string description, string name, string price, FoodType _type)
        {
            base.description = description;
            base.name = name;
            base.price = price;
            type = _type;

        }

       
       


    }


    public class Toy : Item
    {
        public List<string> NationalityList = new List<string>();

        public Toy(string description, string name, string price)
        {
            base.description = description;
            base.name = name;
            base.price = price;
            //NationalityList = nation;
        }

        //public Toy()
        //{
        //    NationalityList.Add("Austria");
        //    NationalityList.Add("Norway");
        //    NationalityList.Add("Brazil");
        //    NationalityList.Add("Peru");
        //    NationalityList.Add("South Korea");
        //    NationalityList.Add("Burma");
        //    NationalityList.Add("Egypt");
        //    NationalityList.Add("Finland");
        //    NationalityList.Add("Moroco");
        //    NationalityList.Add("Hawaii");

        //}


    }






}
