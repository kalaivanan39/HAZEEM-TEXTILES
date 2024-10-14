using System.ComponentModel.DataAnnotations;

namespace HazeemTextiles.Model
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
