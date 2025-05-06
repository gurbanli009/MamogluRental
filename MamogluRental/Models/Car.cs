namespace MamogluRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public string Tranmission { get; set; }
        public int MinimumAge { get; set; }
        public decimal PricePerDay { get; set; }
        public string Status { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }

}
