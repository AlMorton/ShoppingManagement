using Domain.Entities;

namespace Domain.Entities
{
    public class Person : Entity
    {
        public string Forename { get; private set; }
        public string Surname { get; private set; }

        public Person(string forename, string surname)
        {
            Forename = forename;
            Surname = surname;
        }
    }
}
