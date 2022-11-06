namespace ContainDuplicate;
public static class ContainsDuplicates
{
    //foreach implementation
    public static bool ContainsDuplicatesForeach<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        foreach(var item in enumerable)
        {
            if(!set.Add(item))
                return true;
            
        }

        return false;
    }

    //Linq.Any implementation
    public static bool ContainsDuplicatesLinqAny<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        return enumerable.Any(element => !set.Add(element));
    }

    //Linq.All implementation
    public static bool ContainsDuplicatesLinqAll<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        return !enumerable.All(set.Add);
    }

    //Distinct implementation
    public static bool ContainsDuplicatesDistinct<T>(IEnumerable<T> enumerable)
    {
       
        return enumerable.Distinct().Count() != enumerable.Count();
       
    }

    public static bool ContainsDuplicatesToHashSet<T>(IEnumerable<T> enumerable)
    {
        return enumerable.ToHashSet().Count != enumerable.Count();
    }
}