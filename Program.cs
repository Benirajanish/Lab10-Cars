using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cars = new ArrayList();

            cars.Add(new Car("Cadillac", "Escalade", 2017, 40000));
            cars.Add(new Car("Chevrolet", "Prism", 2017, 45_000));
            cars.Add(new Car("GMC", "Terrain", 2017, 50_000));
            cars.Add(new Car("BMW", "3-Series", 2017, 70_000));
            cars.Add(new Car("Toyota", "Highlander", 2017, 35_000));
            cars.Add(new UsedCar("Ford", "Lincoln", 2016, 42_000, 35_065));
            cars.Add(new UsedCar("Honda", "Accord", 2010, 38_000, 95_905));
            cars.Add(new UsedCar("Lamborghini", "Aventador", 2012, 280_000, 85_358));


            bool success = true;

            Validator validate1 = new Validator();

            while (success == true)
            {

                Console.WriteLine($"{"S.No",-10} {"Make",-15} {"Model",-15} {"Year",-15} {"Price",-15} {"Mileage",-15}");
                Console.WriteLine("========================================================================================\n");

                int count = 0;
                foreach (Car c in cars)
                {
                    Console.WriteLine($"{count + 1,-10}{c}\n");
                    count++;

                }

                Console.WriteLine($"{ count + 1,-10}{"Quit"}");

                Console.WriteLine("\nWhich car would you like ?\n ");
                string choice1 = Console.ReadLine();

                bool success1 = int.TryParse(choice1, out int choice);

                if ((count + 1) == choice)
                {
                    Console.WriteLine("Have a great day!\n");
                    success = false;
                }
                else if (choice > cars.Count || choice <= 0)
                {
                    Console.WriteLine("Invalid number. please enter a valid number:");
                }
                else
                {
 
                    Car Display = (Car)(cars[choice - 1]);


                    Console.WriteLine(Display.ToString());


                   

                    Console.WriteLine("\n Would you like to buy this car(y/n) ? \n ");
                    string userinput = Console.ReadLine().ToLower();



                    bool value = validate1.Validate(userinput);

                    if (value == true)
                    {

                        cars.RemoveAt(choice - 1);
                    }

                }
               

            }

            Console.ReadLine();
        }
    }

}

