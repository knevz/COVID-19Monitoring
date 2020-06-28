using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IPUMRepository
    {
        Task<List<PUM>> GetPUMsAsync();
        Task<PUM> GetPUMByIdAsync(int id);
        Task<PUM> AddPUMAsync(PUM pum);
        Task<PUM> UpdatePUMAsync(PUM pum);
        Task<PUM> DeletePUMAsync(int id);
    }
}
