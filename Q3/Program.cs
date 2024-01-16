using Q3;

var car = new Car("pride", 1999, 1000, 4, 500);
Vehicle.AddVehicle(car);

var car1 = new Truck("FH", 1999, 1000, 4, 10000);
Vehicle.AddVehicle(car1);

car1.RentalPrice();

Vehicle.CarDetails();


