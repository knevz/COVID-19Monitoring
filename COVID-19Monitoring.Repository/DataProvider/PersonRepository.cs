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
    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext _db = new DatabaseContext();

        public async Task<Person> AddPersonAsync(Person person)
        {
            _db.People.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person> DeletePersonAsync(int id)
        {
            Person person = await _db.People.FindAsync(id);
            _db.People.Remove(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>> GetPeopleAsync()
        {
            return await _db.People.AsNoTracking().ToListAsync();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _db.People.FindAsync(id);
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            _db.Entry(person).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return person;
        }
    }
}
