using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Validator
    {
        public bool Validate(string input)
        {

            if (input == "y")
            {
                
                Console.WriteLine("\nExcellent! Our finance department will be with you shortly. \n");

                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.Write("Invalid input. ");
                return Validate(input);
            }
            
        }
    }
}
