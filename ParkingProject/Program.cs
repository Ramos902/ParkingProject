using System.Globalization;
using Entities;

namespace ParkingProject
{
    class Program
    {
        public static void Main(string[] args)
        {
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
                System.Console.WriteLine("========| Parking System |========");
                Console.WriteLine("Input your option:");
                Console.WriteLine("1 - Add Vehicle");
                Console.WriteLine("2 - Remove Vehicle");
                Console.WriteLine("3 - List Vehicle");
                Console.WriteLine("4 - End Program");
            }
        }
    }
}