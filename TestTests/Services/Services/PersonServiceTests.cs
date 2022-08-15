using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.Services.Services.Tests
{
    [TestClass()]
    public class PersonServiceTests
    {
        [TestMethod()]
        public void GetByIdTest()
        {
            var personService = new PersonService();
            var result = personService.GetById(1);
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void SaveTest()
        {
            var personService = new PersonService();
            Person person = new Person()
            {
                FirstName = "Leonardo",
                LastName = "Robert",
                Id = 1
            };
            personService.Save(person);
            var result = personService.GetById(1);
            Assert.AreEqual(person.FirstName, result.FirstName);
        }
    }
}