namespace StackOverFlow;

public class Logic
{
    public void A()
    {
        B();
    }

    private void B()
    {
        C();
    }

    private void C()
    {
        D();
    }

    private void D()
    {
        A();
    }
}