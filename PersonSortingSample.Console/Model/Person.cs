namespace PersonSortingSample.Console.Model;

public class Person : IComparable<Person>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int Age { get; set; }

    public Person() { }

    public Person(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public int CompareTo(Person? other)
    {
        if (other is null) return 1;
        //use culture-independent comparison:
        return StringComparer.Ordinal.Compare(Name, other.Name);
    }

    public override string ToString()
    {
        return $"{Name}, {Email}, {Age}";
    }
}
