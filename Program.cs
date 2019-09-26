using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Yuky Han

namespace pet
{
    class Program
    {
        //Game
        class Game
        {

            public void Welcome()
            {
                Console.Title = "MY PET: MY SOULMATE by Yuky Han";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\t\t.:*..::.　MY PET: MY SOULMATE　.:*:.:. "); //顔文字

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\nEnter key for continue Game");

                Console.ReadKey();
            }

            public void End()
            {
                Console.WriteLine("Please, Wait.......... ");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Now, Your friend is 1 years old! (*′▽`*) ");
                Console.ReadKey();


            }

        }

        //Player play game, information
        class Player
        {

            public void Adopt()
            {

                Console.WriteLine("Enter your birthday (mm/dd)");
                string birthday = Console.ReadLine();

                Console.WriteLine($"\nHere is an egg for you (*´∀`*)  ");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\nA baby penguin hatches from the egg ☆(*’∀’*)/☆ ");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();

            }
        }

        //Pet class - Parents class
        public class Pet
        {
            //set property,(data type_)
            public string foody;
            public string pname;
            public string sound;

            public bool ispoop = true;

            //set Random color
            public void Color()
            {
                //Random color for pet
                string[] Color = { "yellow", "blue", "red", "green" };
                Random random = new Random();
                int num = random.Next(Color.Length);
                string col = Color[num];

                Console.WriteLine("You have a " + col + " penguin, " + pname + "!!");
            }

            //Eat 
            public void Eat()
            {
                Console.WriteLine("\n" + pname + " looks hungry now \nWill you feed your tiny friend? y/n");
                string a = Console.ReadLine();

                if (a == "y")
                {
                    Console.WriteLine("your " + pname + " is eating " + foody + " now, munch munch");
                    Console.ReadKey();

                }

                else if (a == "n")
                {
                    Console.WriteLine($"Your friend {pname} is intereated in the house.´∀｀");
                    Console.ReadKey();
                }
            }


            //Pooping!!1@!!!
            public void Poop()
            {

                if (ispoop == true)
                {
                    Console.WriteLine($" Pooped!!´Д｀ Please clean the house. y/n");
                    string a = Console.ReadLine();

                    if (a == "y")
                    {
                        Console.WriteLine("It is clean now!");

                    }
                    else 
                    {

                        Console.WriteLine("Pleaseeeeeeeeeeeeeeeee");
                        Poop();
                    }

                }

                else if (ispoop == false)
                {
                    Console.WriteLine("House is so happy now!");
                }

                Console.ReadKey();
            }


            //going to sleep
            public void Sleep()
            {
                Console.WriteLine($"Your tiny friend {pname} is falling asleep ZzzzZzz");
                Console.ReadKey();
            }

        }

        //Child class- penguin
        public class Penguin : Pet
        {

            public Penguin(string sound, string pname, string foody)
            {
                base.sound = sound;
                base.pname = pname;
                base.foody = foody;

                base.ispoop = ispoop;

            }

        }

        //House 
        class House
        {
            string cage;

            public House(string cage)
            {
                this.cage = cage;

            }

            public void About()
            {
                Console.WriteLine($"Your friend is looking around and likes the {cage} house.´∀｀");
                Console.ReadKey();
            }
        }


         //Toy
         class Toy
         {
             string toy;

             public Toy(string toy)
             {
                    this.toy = toy;
             }

             public void About()
             {
                 Console.WriteLine("Found " + toy + "!!!");
                    Console.ReadKey();
             }
         }


        static void Main(string[] args)
        {
            Game game = new Game();
           Player player = new Player();
            
            game.Welcome();
            player.Adopt();

            //Inheritance variable - Child class
            Penguin penguin = new Penguin("Squawk, Squawk", "winter", "a fish");
            penguin.Color(); //for random color

            Console.WriteLine(penguin.sound);
            Console.ReadKey();

            //House object, diamond
            House house = new House("diamond");
            house.About();

            penguin.Eat();

            penguin.ispoop = true;
            penguin.Poop();

            //Toy object. Ice
            Toy ice = new Toy("an ice cube");
            ice.About();

            penguin.Sleep();
            game.End();


        }
    }
}



    

