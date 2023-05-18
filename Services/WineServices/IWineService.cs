
using practice_api.Models;

namespace practice_api.Services.WineServices
{
    public interface IWineService
    {
        Task<List<Wine>> GetAllWines();

        Task<Wine> GetWineById(int id);

        Task<List<Wine>> AddNewWine(Wine newWine);
    }
}