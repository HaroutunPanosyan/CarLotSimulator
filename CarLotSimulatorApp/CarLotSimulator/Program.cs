using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            CarLot carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car();
            // Car car2 = new Car();
            //Car car3 = new Car();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // Dot Notation Method
            car1.Make = "Ford";
            car1.Year = 1998;
            car1.IsDriveable = true;
            car1.Model = "F-250";
            car1.EngineNoise = ("VRrrRrrtT");
            car1.HonkNoise = ("BWAAAH!");
            //car1.MakeEngineNoise();
            //car1.MakeHonkNoise();

            // Object Initializer Sytax
            Car car2 = new Car() { Make = "BMW", Year = 2012, IsDriveable = false, 
                Model = "5 Series", EngineNoise = "Drrrtrrr", HonkNoise = "Eeeee!" };
            
            //car2.MakeEngineNoise();
            //car2.MakeHonkNoise();

            // Custom Constructor Method
            Car car3 = new Car("Tesla", "Model S", "heeeee", "wub-wub", 2008, true);
            //car3.MakeEngineNoise();
            //car3.MakeHonkNoise();

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.carLot.Add(car1);
            carLot.carLot.Add(car2);
            carLot.carLot.Add(car3);

            Console.WriteLine("Without String Interpoation");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < carLot.carLot.Count; i++)
            {
                Console.WriteLine(carLot.carLot[i].Make + ", " + carLot.carLot[i].Model + ", " + carLot.carLot[i].Year + ", " +
                    carLot.carLot[i].IsDriveable + ", " + carLot.carLot[i].EngineNoise + ", " + carLot.carLot[i].HonkNoise);
            }
            Console.WriteLine();
            Console.WriteLine("With String Interpolation");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < carLot.carLot.Count; i++)
            {
                Console.WriteLine($"{carLot.carLot[i].Make}, {carLot.carLot[i].Model}, {carLot.carLot[i].Year}, " +
                $" {carLot.carLot[i].IsDriveable}, {carLot.carLot[i].EngineNoise}, {carLot.carLot[i].HonkNoise}");
            }
        }
    }
}
