using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface ISymptomRepository
    {
        Task<List<Symptom>> GetSymptomsAsync();
        Task<Symptom> GetSymptomByIdAsync(int id);
        Task<Symptom> AddSymptomAsync(Symptom symptom);
        Task<Symptom> UpdateSymptomAsync(Symptom symptom);
        Task<Symptom> DeleteSymptomAsync(int id);
    }
}
