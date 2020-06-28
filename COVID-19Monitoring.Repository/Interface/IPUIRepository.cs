using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IPUIRepository
    {
        Task<List<PUI>> GetPUIsAsync();
        Task<PUI> GetPUIByIdAsync(int id);
        Task<PUI> AddPUIAsync(PUI pui);
        Task<PUI> UpdatePUIAsync(PUI pui);
        Task<PUI> DeletePUIAsync(int id);
    }
}
