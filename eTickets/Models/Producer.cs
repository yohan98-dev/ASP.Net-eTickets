using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePicURL { get; set; }
        [Required]
        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
