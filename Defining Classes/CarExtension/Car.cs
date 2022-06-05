using System;

namespace CarManufacturer
{
    class Car
    {
        private string make; // Field for make
        private string model; // Field for model
        private int year; // Field for year
        private double fuelQuantity;
        private double fuelConsumption;

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
            string carInfo = $"Make: {this.Make}\n" +
                $"Model: {this.Model}\n" +
                $"Year: {this.Year}\n" +
                $"Fuel: {this.FuelQuantity:f2}";

            return carInfo;
        }
    }
}
