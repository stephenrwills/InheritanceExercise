using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird();
            bird1.CanFly = true;
            bird1.BeakLength = 2.25;
            bird1.WingSpan = 3.5;
            bird1.HasWings = true;

            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var chameleon = new Reptile()
            {
                AreColdBlooded = true,
                LayEggs = true,
                Habitat = "terrarium",
                HasScales = true

            };

            Console.WriteLine("A chameleon has the following characteristics:"); 
            chameleon.printReptileInfo();
            Console.WriteLine();
            Console.WriteLine("A certain bird has the following characteristics:");
            bird1.printBirdInfo();
           

        }
    }
}
