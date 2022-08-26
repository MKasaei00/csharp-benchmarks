namespace HeavyOperationAttributeDemo.TestBed;

public class Third
{
    public List<string> LoadFromDatabase()
    {
        return Enumerable.Empty<string>().ToList();
    }

    public List<string> LoadFromCache()
    {
        return Enumerable.Empty<string>().ToList();
    }
}