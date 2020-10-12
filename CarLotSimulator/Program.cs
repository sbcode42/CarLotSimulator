using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            CarLot lot = new CarLot();
            

            var mazda = new Car();
            lot.CarList.Add(mazda);

            mazda.Make = "Mazda";
                mazda.Model = "CX-5";
                mazda.Year = 2016;
                mazda.EngineNoise = "Zoom zoom zoom";
                mazda.HonkNoise = "beeeep";
                mazda.IsDrivable = true;
            

            var ford = new Car();     //fix this
            lot.CarList.Add(ford);
                ford.Make = "Ford";
                ford.Model = "Mustang";
                ford.Year = 2011;
                ford.EngineNoise = "Growwwlllll";
                ford.HonkNoise = "beyeeeep";
                ford.IsDrivable = true;
            

            
                var impala = new Car(2001, "Chevy", "Impala", "VROOM", "Loud beep", true);
                lot.CarList.Add(impala);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model:{car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("----------------");
            }
          
                
                
                //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
           // done //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
