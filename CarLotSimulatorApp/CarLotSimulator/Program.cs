using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();

            Car bmw = new Car();
            lot.CarList.Add(bmw);

            bmw.Year = 2016;
            bmw.Make = "BMW";
            bmw.Model = "328i";
            bmw.EngineNoise = "Vroom";
            bmw.HonkNoise = "Beep Boop";
            bmw.IsDriveable = true;

            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            //Object initializer syntax
            Car celica = new Car() { Year = 2000, Make = "Toyota", Model = "Celica", EngineNoise = "Nothing", HonkNoise = "Help" };
            lot.CarList.Add(celica);

            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            //Constructor initialization
            Car mustang = new Car(2018, "Ford", "Mustang", "Vroom", "Honk");
            lot.CarList.Add(mustang);

            mustang.MakeEngineNoise();
            mustang.MakeHonkNoise();

            Console.WriteLine("------------------");

            //*************BONUS X 2*************//
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
