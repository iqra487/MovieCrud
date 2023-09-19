namespace MovieCrud.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? title { get; set; }
        public DateTime releasedDate { get; set; }

        public string? genre { get; set; }

        public decimal price { get; set; }
    }
}
