using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    public abstract class Vehicle
    {
        protected static List<Vehicle> _vehicles = new List<Vehicle>();
        public string Name { get; set; }
        public int Model { get; set; }
        public int Price { get; set; }
        public int CountOfCar{ get; set; }
        public Vehicle(string name, int model, int price, int countOfCar)
        {
            Name = name;
            Model = model;
            Price = price;
            CountOfCar = countOfCar;
        }

        public abstract void RentalPrice();
        public static void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }
        public abstract void shoewDetails();
        public static void CarDetails()
        {

            foreach (var vehicle in _vehicles)
            {
                vehicle.shoewDetails();
            }
        }


    }
}
