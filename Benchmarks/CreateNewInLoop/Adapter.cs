namespace CreateNewInLoop;

public interface IAdapter
{
    string Convert(int number);
}

public class Adapter : IAdapter
{
    public Adapter()
    {
    }

    public string Convert(int number)
    {
        return $"{number}";
    }
}