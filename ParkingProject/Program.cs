using System.Globalization;
using Entities;

namespace ParkingProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            //Input parking info
            System.Console.WriteLine("========| Parking System |========");
            System.Console.WriteLine("Input the Initial Price: ");
            decimal initialPrice = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Input the Hour Price: ");
            decimal hourPrice = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Parking Instance
            Parking parking = new Parking(initialPrice, hourPrice);

            //Program Run
            bool running = true;
            while (running = true)
            {
                Console.Clear();
                System.Console.WriteLine("========| Parking System |========");
                Console.WriteLine("Input your option:");
                Console.WriteLine("1 - Add Vehicle");
                Console.WriteLine("2 - Remove Vehicle");
                Console.WriteLine("3 - List Vehicle");
                Console.WriteLine("4 - End Program");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        parking.AddCar();
                        break;
                    case 2:
                        parking.RemoveCar();
                        break;
                    case 3:
                        parking.ListCars();
                        break;
                    case 4:
                        Console.WriteLine("Program Exit! Press enter to continue.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Invalid Option! Try again.");
                        break;
                }
            }
        }
    }
}