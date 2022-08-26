using HeavyOperationAttributeDemo.Utility;

namespace HeavyOperationAttributeDemo.TestBed;

public class FirstBusiness
{
    [HeavyOperation]
    public List<string> LoadFromDatabase()
    {
        return Enumerable.Empty<string>().ToList();
    }

    [HeavyOperation]
    public List<string> LoadFromCache()
    {
        return Enumerable.Empty<string>().ToList();
    }
}