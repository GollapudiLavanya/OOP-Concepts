using System;
using System.Collections.Generic;
using System.Text;

namespace oopsconcepts
{

    public class Laptop
    {
        private string brand;
        private string model;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }
    }
}