using Test.Model;
using Test.Services.Interface;

namespace Test.Services.Services
{
    public class PersonService : IPersonService
    {
        private static List<Person> _person = new List<Person>()
        {
            new Person(){Id = 1, FirstName = "Luan", LastName = "Ducate"},
            new Person(){Id = 2, FirstName = "Rahul", LastName = "Patel"},
        };

        public List<Person> GetAll()
        {
            return _person;
        }

        public Person GetById(int Id)
        {
            return _person.FirstOrDefault(x => x.Id == Id);
        }

        public void Save(Person person)
        {
            if (GetById(person.Id) == null)
                _person.Add(person);
            else
            {
                _person.Remove(GetById(person.Id));
                _person.Add(person);
            }
        }
    }
}
