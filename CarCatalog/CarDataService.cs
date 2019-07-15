using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCatalog
{
    public static class CarDataService
    {
        static string path = @"..\..\myvehicles.csv";

        static CarDataService()
        {
            var data = File.ReadAllLines(path);

            cars = data.Select(CarModel.Parse).ToList();
        }

        static readonly List<CarModel> cars;

        public static List<string> GetMakes()
        {
            throw new NotImplementedException();
        }

        public static List<CarModel> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public static List<CarModel> GetCarsByMake(string make)
        {
            throw new NotImplementedException();
        }


    }
}
