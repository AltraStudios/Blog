public class KnightFactory : IFactory
{
    public ISoldier Create() => new Knight();
}
