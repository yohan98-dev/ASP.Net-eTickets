using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name = "Profile Pic")]
		[Required(ErrorMessage = "Profile picture is required")]
		public string? ProfilePicURL { get; set; }

		[Display(Name = "Full Name")]
		[Required(ErrorMessage = "Name is required")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="Name must be within 3 and 50 chars")]
		public string? FullName { get; set;}

		[Display(Name = "Biography")]
		[Required(ErrorMessage = "Bio is required")]
		public string? Bio { get; set;}

        //Relationships

        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
