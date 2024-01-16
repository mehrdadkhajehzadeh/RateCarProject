using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public class Truck : Vehicle
    {
        public int LoadWeight { get; set; }
        public Truck(string name, int model, int price, int countOfCar, int loadWeight) : base(name, model, price, countOfCar)
        {
            LoadWeight = loadWeight;
        }

        public override void RentalPrice()
        {
            var rentalPrice = LoadWeight * Price;
            Console.WriteLine($"rental price is {rentalPrice}");
        }
        public override void shoewDetails()
        {
            Console.WriteLine($"Name:{Name} Model:{Model} LoadWeight:{LoadWeight}");
        }


    }
}
