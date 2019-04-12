public class AbstractFactory
{
    ArcherFactory archFactory = new ArcherFactory();
    KnightFactory knFactory = new KnightFactory();
    public ISoldier CreateArcher()
    {
        return archFactory.Create();
    }

    public ISoldier CreateKnight()
    {
        return knFactory.Create();
    }
}
