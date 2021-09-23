using Domain.Entities;

namespace Domain.Tests.Entities
{
    public class Person : Entity
    {
        public string Forename { get; private set; }
        public string Surname { get; }

        public Person(string forename, string surname)
        {
            Forename = forename;
            Surname = surname;
        }
    }
}
