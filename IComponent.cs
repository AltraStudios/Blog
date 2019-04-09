public interface IComponent
{
    void ChangeState();
    void Receive(string source, int state);
    void Listen(string target);
}

public class ComponentA : IComponent
{
    private Mediator _m;
    public ComponentA(Mediator m)
    {
        _m = m;
    }

    public void ChangeState()
    {
        _m.Notify("ComponentA", 1);
    }

    public void Listen(string target)
    {
        _m.Listen(target, this);
    }

    public void Receive(string source, int state)
    {
        Console.WriteLine("Received State " + state.ToString() + " from source : " + source);
    }
}

public class ComponentB : IComponent
{
    private Mediator _m;

    public ComponentB(Mediator m)
    {
        _m = m;
    }

    public void ChangeState()
    {
        _m.Notify("ComponentB", 2);
    }

    public void Receive(string source, int state)
    {
        Console.WriteLine("Received State " + state.ToString() + " from source : " + source);
    }

    public void Listen(string target)
    {
        _m.Listen(target, this);
    }
}
