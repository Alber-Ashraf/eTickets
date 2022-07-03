using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cenima
    {
        [Key]
        public int cenimaId { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        //Relationships
        public List<Movie> movies { get; set; }
    }
}
