using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interface
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task<Club> GetByIdAsync(int Id);
        Task<IEnumerable<Club>> GetClubByCity(string City);
        
        bool Add(Club club);
        bool Delete(Club club);
        bool Update(Club club);
        bool Save();

    }
}
