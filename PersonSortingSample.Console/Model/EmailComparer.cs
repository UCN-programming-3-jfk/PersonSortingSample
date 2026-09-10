namespace PersonSortingSample.Console.Model;
public class EmailComparer : IComparer<Person>
{
    public int Compare(Person? first, Person? second)
    {
        if (ReferenceEquals(first, second)) return 0;
        if (first is null) return -1;
        if (second is null) return 1;
        return StringComparer.OrdinalIgnoreCase.Compare(first.Email, second.Email);
    }
}