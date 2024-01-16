using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public class Car : Vehicle
    {
        public int Duration { get; set; }
        public Car(string name, int model, int price, int countOfCar, int duration) : base(name, model, price, countOfCar)
        {
            Duration = duration;
        }
        public override void RentalPrice()
        {
            var rentalPrice = Price * Duration;
            Console.WriteLine($"rental price is {rentalPrice}");
        }
        public override void shoewDetails()
        {
            Console.WriteLine($"Name:{Name} Model:{Model} Duration:{Duration}");
        }
    }
}
