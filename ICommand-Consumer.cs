class Program
{
    static ICommand targetCommandsMapping(IDestructible destructable)
    {
        if (destructable is Human)
            return new DieCommand();
        else if (destructable is Tank)
            return new ExplodeCommand();
        else
            return new CollapseCommand();
    }

    static void Main(string[] args)
    {

        List<IDestructible> targets = new List<IDestructible>()
        {
            new Human(),
            new Building(),
            new Tank()
        };

        foreach(var target in targets)
        {
            target.Destruct(targetCommandsMapping(target));
        }

        Console.ReadKey();
    }
}
