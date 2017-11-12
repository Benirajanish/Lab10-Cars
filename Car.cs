using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Car
    {

        private string make;
        private string model;
        private int year;
        private double price;
        

        public string Make
        {
            get { return make; }
            set { make= value; }
        }

        public string Model
        {
            get { return model; }
            set {model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

       

        public Car(string make, string model, int year,double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            
        }

        public override string ToString()
        {
            return $"{make,-15} {model,-15} {year,-15} {price,-15} ";
        }

    }
}
