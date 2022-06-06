using System;
using System.Collections.Generic;

namespace RawData
{
    public class Tires
    {
        private List<double> tires;

        public List<double> TiresList { get; set; }

        public Tires(List<double> tires)
        {
            this.TiresList = tires;
        }
    }
}
