namespace Entities
{
    class Car
    {
        public string Model { get; set; }
        public string Plate { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Car: {Model} | Plate: {Plate} | Year: {Year}";
        }
        public Car(string modelo, string placa, int year)
        {
            Model = modelo;
            Plate = placa;
            Year = year;
        }

    }
}