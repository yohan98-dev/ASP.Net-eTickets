﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePicURL { get; set; }
        [Required]
        public string FullName { get; set;}

        public string Bio { get; set;}

        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
