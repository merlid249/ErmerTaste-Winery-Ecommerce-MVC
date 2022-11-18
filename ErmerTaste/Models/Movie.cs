using ErmerTaste.Data.Enus;
using System.ComponentModel.DataAnnotations;

namespace ErmerTaste.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
