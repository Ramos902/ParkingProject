using System.Globalization;

namespace Entities
{
    class Parking
    {
        public decimal InitialPrice { get; set; }
        public decimal PricePerHour { get; set; }
        public List<Car> Vehicles { get; set; }
        
        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
            Vehicles = new List<Car>();
        }
        public void AddCar()
        {
            Console.Clear();
            System.Console.WriteLine("| Adding Cars |");
            //Input info for car
            System.Console.WriteLine("Input the car model: ");
            string modelCar = Console.ReadLine();
            System.Console.WriteLine("Input the car plate: ");
            string plateCar = Console.ReadLine();
            System.Console.WriteLine("Input the car year: ");
            int yearCar = int.Parse(Console.ReadLine());

            //Instance of Car
            Car car = new Car(modelCar, plateCar, yearCar);

            //Adding car to List of Vehicles in the parking
            Vehicles.Add(car);

            //CW to confirm the ADD
            System.Console.WriteLine("Car added from parking! Press enter to Continue!");
            Console.ReadKey();
        }
        public void RemoveCar()
        {
            Console.Clear();
            System.Console.WriteLine("| Removing Car |");
            //Input info for car plate
            System.Console.WriteLine("Input the car plate: ");
            string plateCar = Console.ReadLine();

            //Verifing if plate exists, if exists delete from list.
            Car carToRemove = Vehicles.FirstOrDefault(c => c.Plate == plateCar);
            if (carToRemove != null)
            {
                System.Console.WriteLine("Input how much hours the car was parking: ");
                int hours = int.Parse(Console.ReadLine());
                Vehicles.Remove(carToRemove);
                System.Console.WriteLine("Car removed from parking!");
                System.Console.WriteLine($"With the total = R${InitialPrice + PricePerHour * hours},00");
            }
            else
            {
                System.Console.WriteLine("This plate doesn't exists!");
            }
            System.Console.WriteLine("Press enter to Continue!");
            Console.ReadKey();
        }
        public void ListCars()
        {
            Console.Clear();
            System.Console.WriteLine("| Listing Cars |");
            foreach (var carList in Vehicles)
            {
                System.Console.WriteLine(carList.ToString());
            }
            System.Console.WriteLine("Press enter to Continue!");
            Console.ReadKey();
        }
    }
}