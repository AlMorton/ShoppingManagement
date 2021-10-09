using Domain.Entities;
using NUnit.Framework;

namespace Domain.Tests.Entities
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void CTOR_Test()
        {
            var forename = "Bob";
            var surname = "Smith";
            var person = new Person(forename, surname);

            Assert.AreEqual("Bob", person.Forename);
        }
    }
}
