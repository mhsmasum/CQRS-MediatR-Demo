using CQRS_medator.Data;
using CQRS_medator.Models;

namespace CQRS_medator.Repositories
{
    public class PersonRepository : IDisposable, IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SavePerson(Person person)
        {
           await _context.People.AddAsync(person);
           await  _context.SaveChangesAsync();
        }

        public List<Person> GetAll()
        {
            return _context.People.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
