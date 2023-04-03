using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        [Required]
        public string Name { get; set; }

        public string Discription { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
