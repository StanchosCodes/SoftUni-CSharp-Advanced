using System;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption / 100;
        }

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10 / 100;
        }
        public Car()
        {
            this.make = "VW";
            this.model = "Golf";
            this.year = 2025;
            this.fuelQuantity = 200;
            this.fuelConsumption = 10 / 100;
        }

        private string make; // Field for make
        private string model; // Field for model
        private int year; // Field for year
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire tires;

        public Engine Engine { get; set; }
        public Tire Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire tires)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption / 100;
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make // Property for make;
        {
            get { return make; } // Returns the value of string make
            set { make = value; } // Allows you to set another value to the variable make
        }

        public string Model // Property for model
        {
            get { return model; } // Returns the value of string model
            set { model = value; } // Allows you to set another value to the variable model
        }

        public int Year // Property for year
        {
            get { return year; } // Returns the value of int year
            set { year = value; } // Allows you to set another value to the variable year
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distance)
        {
            double neededFuelForTheTrip = distance * this.FuelConsumption;

            if (neededFuelForTheTrip <= this.FuelQuantity)
            {
                this.fuelQuantity -= neededFuelForTheTrip;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder carInfo = new StringBuilder();

            carInfo.AppendLine($"Make: {this.Make}");
            carInfo.AppendLine($"Model: {this.Model}");
            carInfo.AppendLine($"Year: {this.Year}");
            carInfo.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            carInfo.Append($"FuelQuantity: {this.FuelQuantity}");

            return carInfo.ToString();
        }
    }
}
