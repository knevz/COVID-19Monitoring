using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IPlaceRepository
    {
        Task<List<Place>> GetPlacesAsync();
        Task<Place> GetPlaceByIdAsync(int id);
        Task<Place> AddPlaceAsync(Place place);
        Task<Place> UpdatePlaceAsync(Place place);
        Task<Place> DeletePlaceAsync(int id);
    }
}
