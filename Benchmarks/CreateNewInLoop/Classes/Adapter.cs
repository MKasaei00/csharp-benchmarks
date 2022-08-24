namespace CreateNewInLoop.Classes;

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