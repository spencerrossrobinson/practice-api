
namespace practice_api.Models
{
    public class Wine
    {
        public int Id { get; set;}

        public string Name { get; set; }

        public string Producer { get; set;}

        public string Varietal { get; set; }

        public string Country { get; set; }

        public int Year { get; set; }

        public int WinePrice { get; set; }

        public ColorClass Class {get; set; }

        

    }
}