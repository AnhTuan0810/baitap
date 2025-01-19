using System.ComponentModel.DataAnnotations;

namespace buoi3.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

    }
}
