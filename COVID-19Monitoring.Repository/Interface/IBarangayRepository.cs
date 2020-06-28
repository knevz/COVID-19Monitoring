using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IBarangayRepository
    {
        Task<List<Barangay>> GetBarangaysAsync();
        Task<Barangay> GetBarangayByIdAsync(int id);
        Task<Barangay> AddBarangayAsync(Barangay barangay);
        Task<Barangay> UpdateBarangayAsync(Barangay barangay);
        Task<Barangay> DeleteBarangayAsync(int id);
    }
}
