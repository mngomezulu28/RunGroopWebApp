using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interface
{
    public interface IRaceRepository
    {
        Task<IEnumerable<Race>> GetAll();
        Task<Race> GetByIdAsync(int Id);
        Task<IEnumerable<Race>> GetAllRacesCity(string City);

        bool Add(Race race);
        bool Delete(Race race);
        bool Update(Race race);
        bool Save();
    }
}
