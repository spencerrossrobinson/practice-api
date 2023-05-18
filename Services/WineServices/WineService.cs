

using practice_api.Models;

namespace practice_api.Services.WineServices
{
    public class WineService : IWineService
    {
        private static List<Wine> wines = new List<Wine>
       {
        new Wine { Id = 1, Name = "Trigone Rouge", Producer = "Le Soula", Varietal="GSM", Country="France", Year = 2015, WinePrice = 27, Class = ColorClass.Red }
       };
        public async Task<List<Wine>> GetAllWines()
        {
            return wines;
        }
        public async Task<Wine> GetWineById(int id)
        {
            var wine = wines.FirstOrDefault( w => w.Id == id);
            return wine;
        }
        public async Task<List<Wine>> AddNewWine(Wine newWine)
        {
            wines.Add(newWine);
            return wines;
        }


    }
}