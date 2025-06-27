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
        }

        public void AddCar(Car objCar)
        {
            Vehicles.Add(objCar);
        }
        public void RemoveCar(Car objCar)
        {
            Vehicles.Remove(objCar); 
        }
    }
}