﻿using System;

namespace ObjectLifetime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            //myCar.Make = "Ford";
            //myCar.Model = "F150";
            //myCar.Year = 2013;
            //myCar.Color = "Black";

            //Car myThirdCar = new Car("Dodge", "Viper", 2006, "Red");

            //Car myOtherCar;
            //myOtherCar = myCar;

            //Console.WriteLine("{0} {1} {2} {3}", 
            //                  myOtherCar.Make, 
            //                  myOtherCar.Model,
            //                  myOtherCar.Year,
            //                  myOtherCar.Color);


            //myOtherCar.Model = "98";

            //Console.WriteLine("{0} {1} {2} {3}",
            //                  myCar.Make,
            //                  myCar.Model,
            //                  myCar.Year,
            //                  myCar.Color);

            //myOtherCar = null;

            //myCar = null;


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //public Car()
        //{
        //    // you could load from a configuration file,
        //    // a database, etc.
        //    Make = "Nissan";
        //}

        //public Car(string make, string model, int year, string color)
        //{
        //    Make = make;
        //    Model = model;
        //    Year = year;
        //    Color = color;
        //}

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            //Console.WriteLine(Make);

        }

    }
}
