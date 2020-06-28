using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetPeopleAsync();
        Task<Person> GetPersonAsync(int id);
        Task<Person> AddPersonAsync(Person person);
        Task<Person> UpdatePersonAsync(Person person);
        Task<Person> DeletePersonAsync(int id);
    }
}
