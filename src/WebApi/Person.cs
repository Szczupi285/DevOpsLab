namespace WebApi
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(Guid id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}