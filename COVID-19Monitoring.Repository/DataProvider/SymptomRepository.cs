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
    public class SymptomRepository : ISymptomRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();
        public async Task<Symptom> AddSymptomAsync(Symptom symptom)
        {
            _db.Symptoms.Add(symptom);
            await _db.SaveChangesAsync();
            return symptom;
        }

        public async Task<Symptom> DeleteSymptomAsync(int id)
        {
            Symptom symptom = await _db.Symptoms.FindAsync(id);
            _db.Symptoms.Remove(symptom);
            await _db.SaveChangesAsync();
            return symptom;
        }

        public async Task<Symptom> GetSymptomByIdAsync(int id)
        {
            return await _db.Symptoms.FindAsync(id);
        }

        public async Task<List<Symptom>> GetSymptomsAsync()
        {
            return await _db.Symptoms.AsNoTracking().OrderBy(x => x.Indication).ToListAsync();
        }

        public async Task<Symptom> UpdateSymptomAsync(Symptom symptom)
        {
            _db.Entry(symptom).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return symptom;
        }
    }
}
