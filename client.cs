public class Client
{
    public ISoldier archer;
    public ISoldier knight;
    public Client(AbstractFactory aFactory)
    {
        archer = aFactory.CreateArcher();
        knight = aFactory.CreateKnight();
    }
}
