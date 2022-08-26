using HeavyOperationAttributeDemo.TestBed;

namespace HeavyOperationAttributeDemo;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Start");

        var first = new FirstBusiness();
        first.LoadFromDatabase();
        first.LoadFromCache();

        var second = new SecondBusiness();
        second.LoadFromDatabase();
        second.LoadFromCache();

        var third = new Third();
        third.LoadFromDatabase();
        third.LoadFromCache();

        Console.WriteLine("Finish");
    }
}