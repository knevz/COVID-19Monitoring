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
    public class PUIRepository : IPUIRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();

        public async Task<PUI> AddPUIAsync(PUI pui)
        {
            _db.PUIs.Add(pui);
            await _db.SaveChangesAsync();
            return pui;
        }

        public async Task<PUI> DeletePUIAsync(int id)
        {
            PUI pui = await _db.PUIs.FindAsync(id);
            _db.PUIs.Remove(pui);
            await _db.SaveChangesAsync();
            return pui;
        }

        public async Task<PUI> GetPUIByIdAsync(int id)
        {
            return await _db.PUIs.FindAsync(id);
        }

        public async Task<List<PUI>> GetPUIsAsync()
        {
            return await _db.PUIs.AsNoTracking().ToListAsync();
        }

        public async Task<PUI> UpdatePUIAsync(PUI pui)
        {
            _db.Entry(pui).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return pui;
        }
    }
}
