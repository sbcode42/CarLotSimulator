using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

       
        public Car(
            int year, 
            string make, 
            string model, 
            string engineNoise, 
            string honkNoise, 
            bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
        

        public Car()
        {
            CarLot.numberOfCars++;
            //ClassName.StaticMember

        }
        
        
        
        public int Year { get; set; }   //get is read set is write
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()


        public void MakeEngineNoise()
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        //The methods should take one string parameter: the respective noise property   


        //Now that the Car class is created we can instanciate 3 new cars
        //instanciate means make new instances of a class
        //How do I do that? - new Car();

        

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

