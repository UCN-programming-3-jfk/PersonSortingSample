using PersonSortingSample.Console.Model;

namespace PersonSortingSample.Console;

internal class Program
{
    private static readonly List<Person> SamplePeople = new List<Person>
    {
        new Person("Charlie Brown", "charlie.brown@test.org", 32),
        new Person("Eve Johnson", "eve.johnson@mail.com", 45),
        new Person("Alice Smith", "alice.smith@example.com", 28),
        new Person("Diana Williams", "diana.williams@sample.net", 39),
        new Person("Bob Jones", "bob.jones@example.com", 24),
    };

    static void Main(string[] args)
    {
        var people = new List<Person>(SamplePeople);

        PrintListWithTitle("Original:", people);

        people.Sort(); // sort by Name via IComparable<Person>
        PrintListWithTitle("Sorted by Name:", people);

        people.Sort(new EmailComparer());
        PrintListWithTitle("Sorted by Email:", people);

        people.Sort(new AgeComparer());
        PrintListWithTitle("Sorted by Age:", people);
    }

    static void PrintListWithTitle(string title, IEnumerable<Person> list)
    {
        System.Console.WriteLine(title);
        foreach (var person in list)
        {
            System.Console.WriteLine(person);
        }
        System.Console.WriteLine();
    }
}