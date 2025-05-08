using System.ComponentModel.DataAnnotations;

namespace MamogluRental.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gmail { get; set; }
        public string Message { get; set; }

        public int? UserId { get; set; } // Optional relationship
        public User? User { get; set; }
    }
}
