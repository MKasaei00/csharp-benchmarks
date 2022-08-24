using System.Runtime.CompilerServices;

namespace InlineMethod.Classes;

public class Adapter : IAdapter
{
    public Adapter()
    {
    }

    public string Convert(int number)
    {
        return $"{number}";
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string InlineConvert(int number)
    {
        return $"{number}";
    }
}