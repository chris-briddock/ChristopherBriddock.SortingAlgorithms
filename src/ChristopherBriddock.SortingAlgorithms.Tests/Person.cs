namespace ChristopherBriddock.SortingAlgorithms.Tests
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        } 

        public int CompareTo(Person? other)
        {
            return Age.CompareTo(other!.Age);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Person other)
            {
                return Name == other.Name && Age == other.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}