namespace Entities
{
    class Car
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Year { get; set; }

        public Car(string modelo, string placa, int year)
        {
            Modelo = modelo;
            Placa = placa;
            Year = year;
        }
    }
}