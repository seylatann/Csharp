using System;

namespace House_Project
{
    class House
    {

        private int area;


        public House(int aArea)
        {
            Area = aArea;
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }


    }

    class Door
    {
        public string color;



        public Door(string aColor)
        {
            color = aColor;

        }

        public void ShowData()
        { Console.WriteLine("I'm a door that's colored " + color + "."); }

      
    }


    

    class Person
    {
        public string name;

        public Person(string aName)
        {
            name = aName;
        }
    }
}
