using System.ComponentModel.DataAnnotations;

namespace buoi3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual UserProfile Profile { get; set; }
    }
}
