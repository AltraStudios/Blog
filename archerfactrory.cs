public class ArcherFactory : IFactory
{
    public ISoldier Create() => new Archer();
}
