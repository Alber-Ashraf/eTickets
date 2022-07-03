using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public MovieCategory movieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }

        //Cenima
        public int cenimaId { get; set; }
        [ForeignKey("cenimaId")]
        public Cenima cenima { get; set; }

        //Producer
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }
    }
}
