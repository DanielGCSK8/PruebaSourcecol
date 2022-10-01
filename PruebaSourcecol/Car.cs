using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaSourcecol
{
    class Car
    {
        public List<DataCar> Cars(List<DataCar> CarList)
        {
            String currentYear = DateTime.Now.ToString("yyyy");
            int cYear = Int32.Parse(currentYear);
            var year = CarList.Where(x => (cYear - x.Model <= 5)).ToList();
            return year;
        }

        public void caller()
        {
            List<DataCar> CarList = new List<DataCar>();
            CarList.Add(new DataCar { Brand = "Mazda", Model = 2022, Color = "Rojo" });
            CarList.Add(new DataCar { Brand = "Kia", Model = 2020, Color = "Blanco" });
            CarList.Add(new DataCar { Brand = "Toyota", Model = 2016, Color = "Gris" });
            CarList.Add(new DataCar { Brand = "Hyundai", Model = 2018, Color = "Negro" });
            CarList.Add(new DataCar { Brand = "Chevrolet", Model = 2015, Color = "Negro Diamante" });
            foreach (DataCar c in Cars(CarList))
            {
                Console.WriteLine("Marca: " + c.Brand + " Modelo: " + c.Model + " Color: " + c.Color + "\n");
            }
        }
    }
}