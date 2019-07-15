using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCatalog
{
    public class CarModel
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Class { get; set; }
        public string Transmission { get; set; }
        public int Cylinders { get; set; }
        public double Engine { get; set; }
        public string FuelType { get; set; }
        public double City { get; set; }
        public double Highway { get; set; }
        public double Combined { get; set; }

        public static CarModel Parse(string s)
        {
            var data = s.Split(',');

            var car = new CarModel
            {
                Year = int.Parse(data[0]),
                Make = data[1],
                Model = data[2],
                Class = data[3],
                Transmission = data[4],
                Cylinders = int.Parse(data[5]),
                Engine = double.Parse(data[6]),
                FuelType = data[7],
                City = double.Parse(data[8]),
                Highway = double.Parse(data[9]),
                Combined = double.Parse(data[10])
            };

            return car;
        }
    }

   

}
