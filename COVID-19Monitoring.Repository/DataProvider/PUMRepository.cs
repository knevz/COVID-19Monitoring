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
    public class PUMRepository : IPUMRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();
        public async Task<PUM> AddPUMAsync(PUM pum)
        {
            _db.PUMs.Add(pum);
            await _db.SaveChangesAsync();
            return pum;
        }

        public async Task<PUM> DeletePUMAsync(int id)
        {
            PUM pum = await _db.PUMs.FindAsync(id);
            _db.PUMs.Remove(pum);
            await _db.SaveChangesAsync();
            return pum;
        }

        public async Task<PUM> GetPUMByIdAsync(int id)
        {
            return await _db.PUMs.FindAsync(id);
        }

        public async Task<List<PUM>> GetPUMsAsync()
        {
            return await _db.PUMs.AsNoTracking().ToListAsync();
        }

        public async Task<PUM> UpdatePUMAsync(PUM pum)
        {
            _db.Entry(pum).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return pum;
        }

    }
}
