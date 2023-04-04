using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Display (Name ="Profile Pic")]
        public string ProfilePicURL { get; set; }
        [Required]
		[Display(Name = "Name")]
		public string FullName { get; set; }

		[Display(Name = "Biography")]
		public string Bio { get; set; }

        //Relationships

        public List<Movie> Movies { get; set; }
    }
}
