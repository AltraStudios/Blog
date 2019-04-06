public interface IDestructible
{
    void Destruct(ICommand _destructCommand);
}
public class Tank : IDestructible
{
    ICommand DestructCommand;
    public void Destruct(ICommand _destructCommand)
    {
        DestructCommand = _destructCommand;
        DestructCommand.Execute();
    }
}

public class Human : IDestructible
{
    ICommand DestructCommand;
    public void Destruct(ICommand _destructCommand)
    {
        DestructCommand = _destructCommand;
        DestructCommand.Execute();
    }
}

public class Building : IDestructible
{
    ICommand DestructCommand;
    public void Destruct(ICommand _destructCommand)
    {
        DestructCommand = _destructCommand;
        DestructCommand.Execute();
    }
}
