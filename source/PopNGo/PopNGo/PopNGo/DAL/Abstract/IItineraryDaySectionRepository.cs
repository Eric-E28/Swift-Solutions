using System.Collections.Generic;
using System.Threading.Tasks;
using PopNGo.Models;
using PopNGo.Models.DTO; // Import the DTO namespace
using PopNGo.DAL.Abstract; // Import the DAL.Abstract namespace

namespace PopNGo.Repositories
{
    public interface IItineraryDaySectionRepository 
    {
        Task<IEnumerable<ItineraryDaySection>> GetAllAsync();
        Task<ItineraryDaySection> GetByIdAsync(int id);
        Task<(ItineraryDaySection, bool)> UpsertAsync(ItineraryDaySection section); // Changed to return a tuple
    }

}