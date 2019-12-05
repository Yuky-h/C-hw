using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binding

{
    public class Store
    {

        public List<Item> Inventory = new List<Item>();



        public Store()
        {
            Inventory.Add(new Food("vega mega", "salad", "3", FoodType.Dry));
            Inventory.Add(new Food("makes you healty", "sandwich", "4", FoodType.Dry));
            Inventory.Add(new Food("welldone", "bread", "10", FoodType.Dry));
            Inventory.Add(new Food("rank 1 beef", "steak", "20", FoodType.Mixed));
            Inventory.Add(new Food("just got from the ocean", "tuna steak", "21", FoodType.Mixed));
            Inventory.Add(new Food("biggest", "fish", "55", FoodType.Wet));
            Inventory.Add(new Food("very tasty", "rice", "3", FoodType.Dry));
            Inventory.Add(new Food("everyone likes", "pizza", "10", FoodType.Mixed));
            Inventory.Add(new Food("simple food", "spaghetti", "11", FoodType.Mixed));
            Inventory.Add(new Food("snow white", "apple", "1", FoodType.Dry));

            //Inventory.Add(new Toy("fastest", "bibycle", "100"));
            //Inventory.Add(new Toy("rinessance", "train", "40"));
            //Inventory.Add(new Toy("a memory of your childhood", "doll", "20"));
            //Inventory.Add(new Toy("kick to the space", "ball", "3"));
            //Inventory.Add(new Toy("watching you in sleep", "teddy bear", "25"));
            //Inventory.Add(new Toy("well flyed", "kite", "10"));
            //Inventory.Add(new Toy("yello bathroom", "duck", "1"));
            //Inventory.Add(new Toy("rude unitied airline", "airplane", "1"));
            //Inventory.Add(new Toy("for cat", "mouse", "2"));
            //Inventory.Add(new Toy("makes you want to do homework", "pen", "1000"));

        }

        public void ShowInventory()
        {
            //food show : name, price, type, description
            //toy show : name, price, description, nationality

            // Console.WriteLine(Inventory.Count);


            int x = 0;

            foreach (var i in Inventory)
            {
                Console.WriteLine("{0} {1} : ${2}",
                   Inventory[x].description, Inventory[x].name, Inventory[x].price);
                x++;
            }


        }

        public void StockInventory()
        {






        }
    }


}