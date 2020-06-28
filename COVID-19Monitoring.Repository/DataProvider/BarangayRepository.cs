using COVID_19Monitoring.Model.DataContext;
using COVID_19Monitoring.Model.Entity;
using COVID_19Monitoring.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.DataProvider
{
    public class BarangayRepository : IBarangayRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();
       
        public async Task<Barangay> AddBarangayAsync(Barangay barangay)
        {
            _db.Barangays.Add(barangay);
            await _db.SaveChangesAsync();
            return barangay;
        }

        public async Task<Barangay> DeleteBarangayAsync(int id)
        {
            Barangay barangay = await _db.Barangays.FindAsync(id);
            _db.Barangays.Remove(barangay);
            await _db.SaveChangesAsync();
            return barangay;
        }

        public async Task<Barangay> GetBarangayByIdAsync(int id)
        {
            return await _db.Barangays.FindAsync(id);
        }

        public async Task<List<Barangay>> GetBarangaysAsync()
        {
            return await _db.Barangays.AsNoTracking().ToListAsync();
        }

        public async Task<Barangay> UpdateBarangayAsync(Barangay barangay)
        {
            _db.Entry(barangay).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return barangay;
        }
    }
}
