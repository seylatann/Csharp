 using System;

namespace House_Project
{


        class Program
    {
        static void Main(string[] args)
        {
            //practice using constructors, methods, and getters/setters.


            House house1 = new House(166);
            Console.WriteLine("I'm a house with an area of " + house1.Area + " m2.");

         

            Door door1 = new Door("blue");
            door1.ShowData();


            Person person1 = new Person("Seyla");
            Console.WriteLine("My  name is  " + person1.name + " and I live here.");




        }



    }
}

