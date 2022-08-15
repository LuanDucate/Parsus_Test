using Test.Model;

namespace Test.Services.Interface
{
    public interface IPersonService
    {
        public Person GetById(int Id);
        public void Save(Person person);
        public List<Person> GetAll();
    }
}
