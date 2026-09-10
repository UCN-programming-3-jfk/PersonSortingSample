namespace PersonSortingSample.Console.Model;
public class AgeComparer : IComparer<Person>
{
    public int Compare(Person? first, Person? second)
    {
        if (ReferenceEquals(first, second)) return 0;
        if (first is null) return -1;
        if (second is null) return 1;
        return first.Age.CompareTo(second.Age);
    }
}