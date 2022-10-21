using System.ComponentModel.DataAnnotations;

namespace AppDemo.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePicURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
