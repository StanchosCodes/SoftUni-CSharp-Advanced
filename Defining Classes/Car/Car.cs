namespace CarManufacturer
{
    class Car
    {
        private string make; // Field for make
        private string model; // Field for model
        private int year; // Field for year

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
    }
}
