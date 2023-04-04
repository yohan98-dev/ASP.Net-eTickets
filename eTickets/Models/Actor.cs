using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Pic")]
        public string ProfilePicURL { get; set; }
        [Required]

		[Display(Name = "Full Name")]
		public string FullName { get; set;}

		[Display(Name = "Biography")]
		public string Bio { get; set;}

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
