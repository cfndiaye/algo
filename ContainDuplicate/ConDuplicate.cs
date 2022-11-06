namespace ContainDuplicate;
public class ConDuplicate
{
    //foreach implementation
    public bool ContainsDuplicatesForeach<T>(IEnumerable<T> enumerable)
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
    public bool ContainsDuplicatesLinqAny<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        return enumerable.Any(element => !set.Add(element));
    }

    //Linq.All implementation
    public bool ContainsDuplicatesLinqAll<T>(IEnumerable<T> enumerable)
    {
        HashSet<T> set = new();

        return !enumerable.All(set.Add);
    }

    //Distinct implementation
    public bool ContainsDuplicatesDistinct<T>(IEnumerable<T> enumerable)
    {
       
        return enumerable.Distinct().Count() != enumerable.Count();
       
    }
}