using COVID_19Monitoring.Model.DataContext;
using COVID_19Monitoring.Model.Entity;
using COVID_19Monitoring.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.DataProvider
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();
       
        public async Task<Place> AddPlaceAsync(Place place)
        {
            _db.Places.Add(place);
            await _db.SaveChangesAsync();
            return place;
        }

        public async Task<Place> DeletePlaceAsync(int id)
        {
            Place place = await _db.Places.FindAsync(id);
            _db.Places.Remove(place);
            await _db.SaveChangesAsync();
            return place;
        }

        public async Task<Place> GetPlaceByIdAsync(int id)
        {
            return await _db.Places.FindAsync(id);
        }

        public async Task<List<Place>> GetPlacesAsync()
        {
            return await _db.Places.AsNoTracking().OrderBy(x => x.PlaceOfOrigin).ToListAsync();
        }

        public async Task<Place> UpdatePlaceAsync(Place place)
        {
            _db.Entry(place).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return place;
        }
    }
}
