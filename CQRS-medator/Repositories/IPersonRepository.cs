using CQRS_medator.Models;

namespace CQRS_medator.Repositories
{
    public interface IPersonRepository
    {
        void Dispose();
        List<Person> GetAll();
        Task SavePerson(Person person);
    }
}