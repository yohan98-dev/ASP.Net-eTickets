using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        [Display (Name = "Cinema Logo")]
        public string Logo { get; set; }
		[Display(Name = "Cinema Name")]
		[Required]
        public string Name { get; set; }
		[Display(Name = "Cinema Description")]
		public string Discription { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
